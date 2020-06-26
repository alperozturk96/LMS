using LMS_160706300.Core;
using LMS_160706300.Models;
using MaterialSkin.Controls;
using System;
using System.Windows.Forms;

namespace LMS_160706300.Menus
{
    public partial class UpdateFromLibrary : Form
    {
        private readonly MongoDBOperations mongoDBOperations = new MongoDBOperations();
        private readonly Superintend superintend;
        private bool navigate = false;

        public UpdateFromLibrary()
        {
            InitializeComponent();

            Form materialForm = this;
            superintend = new Superintend(materialForm);
        }


        private void SendUserInputForListOperation(string userInput, string columnName)
        {
            if (columnName == "Year" || columnName == "BorrowedCount" || columnName == "Quantity")
            {
                var recordsInt = mongoDBOperations.SelectRecordsByToList<Book>("Books", Convert.ToInt32(userInput), columnName);
                dataGVUListedBooks.DataSource = recordsInt;
            }
            var records = mongoDBOperations.SelectRecordsByToList<Book>("Books", userInput, columnName);
            dataGVUListedBooks.DataSource = records;
        }


        private void SearchBook(object sender, EventArgs e)
        {
            int textBoxEmptiness = -1;
            string controlName = "";
            string inputValue = "";

            foreach (Control i in this.Controls)
            {
                if (i.GetType() == typeof(MaterialSingleLineTextField))
                {
                    if (i.Text.Length > 0)
                    {
                        controlName = i.Name.ToString();
                        inputValue = i.Text;
                        textBoxEmptiness++;
                    }
                }
            }
            if (textBoxEmptiness == 0 || textBoxEmptiness != 1)
            {
                MessageBox.Show("No field to search or multi field entered at the same time.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            if (textBoxEmptiness == 1)
            {
                int startIndex = 7;
                int length = controlName.Length - 7;
                string column = controlName.Substring(startIndex, length);


                SendUserInputForListOperation(inputValue, column);
            }

        }

        private void UpdateFromLibraryFormLoad(object sender, EventArgs e)
        {
            var records = mongoDBOperations.SelectRecords<Book>("Books");
            dataGVUListedBooks.DataSource = records;
        }

        private void CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (dataGVUListedBooks.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
                {
                    dataGVUListedBooks.CurrentRow.Selected = true;
                    textBoxTitle.Text = dataGVUListedBooks.Rows[e.RowIndex].Cells["Title"].FormattedValue.ToString();
                    textBoxAuthor.Text = dataGVUListedBooks.Rows[e.RowIndex].Cells["Author"].FormattedValue.ToString();
                    textBoxEdition.Text = dataGVUListedBooks.Rows[e.RowIndex].Cells["Edition"].FormattedValue.ToString();
                    textBoxPublisher.Text = dataGVUListedBooks.Rows[e.RowIndex].Cells["Publisher"].FormattedValue.ToString();
                    textBoxYear.Text = dataGVUListedBooks.Rows[e.RowIndex].Cells["Year"].FormattedValue.ToString();
                    textBoxQuantity.Text = dataGVUListedBooks.Rows[e.RowIndex].Cells["Quantity"].FormattedValue.ToString();
                    textBoxBorrowedBooks.Text = dataGVUListedBooks.Rows[e.RowIndex].Cells["BorrowedCount"].FormattedValue.ToString();
                    textBoxISBN.Text = dataGVUListedBooks.Rows[e.RowIndex].Cells["ISBN"].FormattedValue.ToString();
                    textBoxId.Text = dataGVUListedBooks.Rows[e.RowIndex].Cells["BookID"].FormattedValue.ToString();
                }
            }
            catch
            {

            }

        }

        private void BackToTheDbOperations(object sender, EventArgs e)
        {
            navigate = true;
            superintend.PrepareForNavigation(this, navigate);
            DatabaseOperations databaseOperations = new DatabaseOperations();
            databaseOperations.Show();
        }



        private void UpdateFromLibraryFormClosing(object sender, FormClosingEventArgs e)
        {
            superintend.FormClosing(e, navigate);
        }

        private void RefreshDataGrid(object sender, EventArgs e)
        {
            var records = mongoDBOperations.SelectRecords<Book>("Books");
            dataGVUListedBooks.DataSource = records;
        }


        [Obsolete]
        private void UpdateBookDocument(object sender, EventArgs e)
        {
            try
            {
                string[] userInput = { textBoxTitle.Text, textBoxAuthor.Text, textBoxYear.Text, textBoxEdition.Text,
                textBoxPublisher.Text, textBoxISBN.Text,textBoxQuantity.Text,textBoxBorrowedBooks.Text};

                var record = mongoDBOperations.SelectRecordsById<Book>("Books", new MongoDB.Bson.BsonObjectId(textBoxId.Text), "_id");

                record.Title = userInput[0];
                record.Year = Int32.Parse(userInput[2]);
                record.Edition = userInput[3];
                record.Publisher = userInput[4];
                record.ISBN = userInput[5];
                record.Author = userInput[1];
                record.Quantity = Int32.Parse(userInput[6]);
                record.BorrowedCount = Int32.Parse(userInput[7]);

                mongoDBOperations.UpdateRecord("Books", record.BookID, record);

                MessageBox.Show("Book succesfully updated.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                RefreshDataGrid(sender, e);
            }
            catch (Exception t)
            {

                MessageBox.Show(t.Message);
            }
        }

        private void ClearFields(object sender, EventArgs e)
        {
            superintend.ClearForm();
        }

        private void ReturnToHomePage(object sender, EventArgs e)
        {
            navigate = true;
            superintend.PrepareForNavigation(this, navigate);
            HomeScreen homeScreen = new HomeScreen();
            homeScreen.Show();
        }
    }
}
