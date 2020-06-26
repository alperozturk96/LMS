using LMS_160706300.Core;
using LMS_160706300.Menus;
using LMS_160706300.Models;
using System;
using System.Windows.Forms;

namespace LMS_160706300.MainMenu
{
    public partial class AddIntoLibrary : Form
    {
        private readonly Superintend superintend;
        private bool navigate = false;
        private readonly MongoDBOperations mongoDBOperations = new MongoDBOperations();

        public AddIntoLibrary()
        {
            InitializeComponent();

            Form materialForm = this;
            superintend = new Superintend(materialForm);
        }

        private void RefreshDataGridView()
        {
            var records = mongoDBOperations.SelectRecords<Book>("Books");
            dataGVAListedBooks.DataSource = records;
        }

        private void AddBook(object sender, EventArgs e)
        {
            try
            {
                if (superintend.ControlTextBoxes() && superintend.ControlInputValues())
                {
                    mongoDBOperations.InsertRecord("Books", new Book
                    {
                        Title = textBoxTitle.Text,
                        Author = textBoxAuthor.Text,
                        ISBN = textBoxISBN.Text,
                        Edition = textBoxEdition.Text,
                        BorrowedCount = Int32.Parse(textBoxBorrowedBooks.Text),
                        Quantity = Int32.Parse(textBoxQuantity.Text),
                        Year = Int32.Parse(textBoxYear.Text),
                        Publisher = textBoxPublisher.Text

                    });
                    RefreshDataGridView();
                    MessageBox.Show("New book succesfully added into library.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
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

        private void BackToTheDbOperations(object sender, EventArgs e)
        {
            navigate = true;
            superintend.PrepareForNavigation(this, navigate);
            DatabaseOperations databaseOperations = new DatabaseOperations();
            databaseOperations.Show();
        }

        private void AddIntoLibraryFormClosing(object sender, FormClosingEventArgs e)
        {
            superintend.FormClosing(e, navigate);
        }

        private void DataGridViewCellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (dataGVAListedBooks.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
                {
                    dataGVAListedBooks.CurrentRow.Selected = true;
                    textBoxTitle.Text = dataGVAListedBooks.Rows[e.RowIndex].Cells["Title"].FormattedValue.ToString();
                    textBoxAuthor.Text = dataGVAListedBooks.Rows[e.RowIndex].Cells["Author"].FormattedValue.ToString();
                    textBoxEdition.Text = dataGVAListedBooks.Rows[e.RowIndex].Cells["Edition"].FormattedValue.ToString();
                    textBoxPublisher.Text = dataGVAListedBooks.Rows[e.RowIndex].Cells["Publisher"].FormattedValue.ToString();
                    textBoxYear.Text = dataGVAListedBooks.Rows[e.RowIndex].Cells["Year"].FormattedValue.ToString();
                    textBoxBorrowedBooks.Text = dataGVAListedBooks.Rows[e.RowIndex].Cells["BorrowedCount"].FormattedValue.ToString();
                    textBoxQuantity.Text = dataGVAListedBooks.Rows[e.RowIndex].Cells["Quantity"].FormattedValue.ToString();
                    textBoxISBN.Text = dataGVAListedBooks.Rows[e.RowIndex].Cells["ISBN"].FormattedValue.ToString();
                }
            }
            catch
            {
            }
        }

        private void AddIntoLibraryFormLoad(object sender, EventArgs e)
        {
            try
            {
                RefreshDataGridView();
            }
            catch (Exception)
            {
                throw;
            }

        }

        private void ReturnToHomeScreen(object sender, EventArgs e)
        {
            navigate = true;
            superintend.PrepareForNavigation(this, navigate);
            HomeScreen homeScreen = new HomeScreen();
            homeScreen.Show();
        }
    }
}
