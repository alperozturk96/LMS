using LMS_160706300.Core;
using LMS_160706300.Models;
using System;
using System.Windows.Forms;

namespace LMS_160706300.Menus
{
    public partial class BorrowFromLibrary : Form
    {
        private readonly MongoDBOperations mongoDBOperations = new MongoDBOperations();
        private string[] updatedBorrowerBookNames = new string[4];
        private string borrowedBook;
        private bool navigate = false;
        private readonly Superintend superintend;
        private readonly string fillOutBook = "";

        public BorrowFromLibrary()
        {
            InitializeComponent();
            Form materialForm = this;
            superintend = new Superintend(materialForm);

        }

        private void BorrowABookFormLoad(object sender, EventArgs e)
        {
            var records = mongoDBOperations.SelectRecords<Book>("Books");
            dataGVBListedBooks.DataSource = records;
        }

        private void DataGridViewCellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (dataGVBListedBooks.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
                {
                    dataGVBListedBooks.CurrentRow.Selected = true;
                    textBoxQuantity.Text = dataGVBListedBooks.Rows[e.RowIndex].Cells["Quantity"].FormattedValue.ToString();
                    textBoxId.Text = dataGVBListedBooks.Rows[e.RowIndex].Cells["BookID"].FormattedValue.ToString();
                    borrowedBook = dataGVBListedBooks.Rows[e.RowIndex].Cells["Title"].FormattedValue.ToString();
                }
            }
            catch (Exception)
            {
            }

        }

        private void RefreshDataGridView()
        {
            var records = mongoDBOperations.SelectRecords<Book>("Books");
            dataGVBListedBooks.DataSource = records;
        }

        private void BackToTheDatabaseOperations(object sender, EventArgs e)
        {
            navigate = true;
            superintend.PrepareForNavigation(this, navigate);
            DatabaseOperations databaseOperations = new DatabaseOperations();
            databaseOperations.Show();
        }

        private void ReturnHomePage(object sender, EventArgs e)
        {
            navigate = true;
            superintend.PrepareForNavigation(this, navigate);
            HomeScreen homeScreen = new HomeScreen();
            homeScreen.Show();
        }

        [Obsolete]
        private void ReturnABook(object sender, EventArgs e)
        {
            if (Login.borrowedBookCount > 0)
            {
                try
                {
                    FindBorrowedBookIndex();
                }
                catch (Exception)
                {
                }
            }
            else
            {
                MessageBox.Show("User doesnt borrow any book before.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        [Obsolete]
        private void UpdateBookDocument(bool borrowOperations)
        {
            var bookRecord = mongoDBOperations.SelectRecordsById<Book>("Books", new MongoDB.Bson.BsonObjectId(textBoxId.Text), "_id");

            if (borrowOperations && Login.borrowedBookCount < 5)
            {
                bookRecord.BorrowedCount += 1;
                bookRecord.Quantity = Int32.Parse(textBoxQuantity.Text) - 1;
            }
            else
            {
                if (Login.borrowedBookCount > 0)
                {
                    bookRecord.BorrowedCount -= 1;
                    bookRecord.Quantity = Int32.Parse(textBoxQuantity.Text) + 1;
                }
            }

            mongoDBOperations.UpdateRecord("Books", bookRecord.BookID, bookRecord);
        }

        [Obsolete]
        private void FindBorrowedBookIndex()
        {
            //int bookIterator = 0;
            //int bookIteratorForUpdate = 0;
            var borrow = mongoDBOperations.SelectRecords<Models.User>("Users");

            foreach (var records in borrow)
            {
                if (Login.loggedUserName.Equals(records.Name) && Login.loggedUserSurname.Equals(records.Surname))
                {
                    for (int bookIterator = 0; bookIterator < 4; bookIterator++)
                    {
                        if (borrowedBook.Equals(records.Borrow.BorrowedBookName[bookIterator].ToString()))
                        {
                            UpdateUserDocument(false, bookIterator);

                            Login.borrowedBookCount -= 1;
                            Login.borrowedBookNames = updatedBorrowerBookNames;

                            MessageBox.Show("Book succesfully returned.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            RefreshDataGridView();
                        }
                    }
                }
            }
        }

        [Obsolete]
        private void UpdateUserDocument(bool borrowOperations, int bookIterator)
        {
            var userRecords = mongoDBOperations.SelectRecordsById<User>("Users", new MongoDB.Bson.BsonObjectId(Login.loggedUserID), "_id");

            if (borrowOperations)
            {
                string loanDate = DateTime.Today.ToShortDateString();
                string loanExpireDate = DateTime.Today.AddDays(2).ToShortDateString();

                userRecords.Borrow.BorrowedBookName[Login.borrowedBookCount] = borrowedBook;
                userRecords.BorrowedBookCount += 1;
                userRecords.Borrow.LoanDate = loanDate;
                userRecords.Borrow.LoanExpireDate = loanExpireDate;

                updatedBorrowerBookNames = userRecords.Borrow.BorrowedBookName;
                UpdateBookDocument(true);
            }
            else
            {
                DateTime dateTime = DateTime.Now;
                string loanDate = new DateTime(dateTime.Year, dateTime.Month, dateTime.Day, 0, 0, 0).ToShortDateString();

                userRecords.Borrow.BorrowedBookName[bookIterator] = fillOutBook;
                userRecords.BorrowedBookCount -= 1;

                userRecords.Borrow.LoanDate = loanDate;
                userRecords.Borrow.LoanExpireDate = loanDate;

                updatedBorrowerBookNames = userRecords.Borrow.BorrowedBookName;
                UpdateBookDocument(false);
            }


            mongoDBOperations.UpdateRecord("Users", userRecords.UserID, userRecords);
        }

        [Obsolete]
        private void BorrowABook(object sender, EventArgs e)
        {
            if (Int32.Parse(textBoxQuantity.Text) > 0 && Login.borrowedBookCount < 5)
            {
                try
                {
                    UpdateUserDocument(true, 0);

                    Login.borrowedBookCount += 1;
                    Login.borrowedBookNames = updatedBorrowerBookNames;

                    MessageBox.Show("Book succesfully borrowed.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    RefreshDataGridView();
                }
                catch (Exception)
                {
                }
            }
            else
            {
                MessageBox.Show("Out of stock can not borrow a book or A user can borrow up to 5 books.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void BorrowFromLibraryFormClosing(object sender, FormClosingEventArgs e)
        {
            superintend.FormClosing(e, navigate);
        }
    }
}
