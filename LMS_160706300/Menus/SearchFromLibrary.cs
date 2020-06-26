using LMS_160706300.Core;
using LMS_160706300.Models;
using MaterialSkin.Controls;
using System;
using System.Windows.Forms;

namespace LMS_160706300.Menus
{
    public partial class SearchFromLibrary : Form
    {
        private readonly Superintend superintend;
        private bool navigate = false;
        private readonly MongoDBOperations mongoDBOperations = new MongoDBOperations();

        public SearchFromLibrary()
        {
            InitializeComponent();

            Form materialForm = this;
            superintend = new Superintend(materialForm);
        }

        private void SearchFromLibraryFormLoad(object sender, EventArgs e)
        {
            var records = mongoDBOperations.SelectRecords<Book>("Books");
            dataGVSListedBooks.DataSource = records;
        }

        private void SearchFromLibraryFormClosing(object sender, FormClosingEventArgs e)
        {
            superintend.FormClosing(e, navigate);
        }

        private void SendUserInput(string userInput, string columnName)
        {
            try
            {
                if (columnName == "Year" || columnName == "BorrowedCount" || columnName == "Quantity")
                {
                    var recordsInt = mongoDBOperations.SelectRecordsByToList<Book>("Books", Convert.ToInt32(userInput), columnName);
                    dataGVSListedBooks.DataSource = recordsInt;
                }
                var records = mongoDBOperations.SelectRecordsByToList<Book>("Books", userInput, columnName);
                dataGVSListedBooks.DataSource = records;
            }
            catch
            {
                MessageBox.Show("Please enter a number value for this section.");
            }

        }

        private void SearchBook(object sender, EventArgs e)
        {
            int textBoxEmptiness = 0;
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


                SendUserInput(inputValue, column);
            }
        }

        private void ClearFields(object sender, EventArgs e)
        {
            superintend.ClearForm();
        }

        private void RefreshDataGridViewCells(object sender, EventArgs e)
        {
            var records = mongoDBOperations.SelectRecords<Book>("Books");
            dataGVSListedBooks.DataSource = records;
        }

        private void DataGridViewCellsClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (dataGVSListedBooks.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
                {
                    dataGVSListedBooks.CurrentRow.Selected = true;
                    textBoxTitle.Text = dataGVSListedBooks.Rows[e.RowIndex].Cells["Title"].FormattedValue.ToString();
                    textBoxAuthor.Text = dataGVSListedBooks.Rows[e.RowIndex].Cells["Author"].FormattedValue.ToString();
                    textBoxEdition.Text = dataGVSListedBooks.Rows[e.RowIndex].Cells["Edition"].FormattedValue.ToString();
                    textBoxPublisher.Text = dataGVSListedBooks.Rows[e.RowIndex].Cells["Publisher"].FormattedValue.ToString();
                    textBoxYear.Text = dataGVSListedBooks.Rows[e.RowIndex].Cells["Year"].FormattedValue.ToString();
                    textBoxBorrowedBooks.Text = dataGVSListedBooks.Rows[e.RowIndex].Cells["BorrowedCount"].FormattedValue.ToString();
                    textBoxQuantity.Text = dataGVSListedBooks.Rows[e.RowIndex].Cells["Quantity"].FormattedValue.ToString();
                    textBoxISBN.Text = dataGVSListedBooks.Rows[e.RowIndex].Cells["ISBN"].FormattedValue.ToString();
                }
            }
            catch
            {
            }
        }

        private void BackToTheHomeScreen(object sender, EventArgs e)
        {
            navigate = true;
            superintend.PrepareForNavigation(this, navigate);
            HomeScreen homeScreen = new HomeScreen();
            homeScreen.Show();
        }
    }
}
