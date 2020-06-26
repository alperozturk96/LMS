using LMS_160706300.Core;
using LMS_160706300.Models;
using System;
using System.Windows.Forms;

namespace LMS_160706300.Menus
{
    public partial class DeleteFromLibrary : Form
    {
        private readonly Superintend superintend;
        private readonly MongoDBOperations mongoDBOperations = new MongoDBOperations();
        private bool navigate = false;

        public DeleteFromLibrary()
        {
            InitializeComponent();

            Form materialForm = this;
            superintend = new Superintend(materialForm);
        }

        private void DeleteBook(object sender, EventArgs e)
        {
            if (superintend.ControlInputValuesForDeleteOperations() && superintend.ControlTextBoxesForDeleteOperations())
            {
                var record = mongoDBOperations.SelectRecordsBy<Book>("Books", textBoxTitle.Text, "Title");
                var bookCollection = mongoDBOperations.SelectRecords<Book>("Books");

                bool successValue = false;

                foreach (var records in bookCollection)
                {
                    if (textBoxTitle.Text.Equals(records.Title) && textBoxEdition.Text.Equals(records.Edition))
                    {
                        mongoDBOperations.DeleteRecord<Book>("Books", record.Title, "Title");
                        successValue = true;
                    }
                }

                if (successValue)
                {
                    MessageBox.Show("Book succesfully deleted from LMS.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    RefreshDataGridViewCells();
                }
                else
                    MessageBox.Show("Book Title or edition is not correct.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        private void BackToTheDbOperations(object sender, EventArgs e)
        {
            navigate = true;
            superintend.PrepareForNavigation(this, navigate);
            DatabaseOperations databaseOperations = new DatabaseOperations();
            databaseOperations.Show();
        }

        private void BackToListAllBookPage(object sender, EventArgs e)
        {
            navigate = true;
            superintend.PrepareForNavigation(this, navigate); ;
            Books bookList = new Books();
            bookList.Show();
        }

        private void DeleteFromLibraryFormClosing(object sender, FormClosingEventArgs e)
        {
            superintend.FormClosing(e, navigate);
        }

        private void DataGridCellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (dataGVD.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
                {
                    dataGVD.CurrentRow.Selected = true;
                    textBoxTitle.Text = dataGVD.Rows[e.RowIndex].Cells["Title"].FormattedValue.ToString();
                    textBoxEdition.Text = dataGVD.Rows[e.RowIndex].Cells["Edition"].FormattedValue.ToString();
                }
            }
            catch
            {
            }
        }

        private void RefreshDataGridViewCells()
        {
            var records = mongoDBOperations.SelectRecords<Book>("Books");
            dataGVD.DataSource = records;
        }

        private void DeleteFromLibraryFormLoad(object sender, EventArgs e)
        {
            var records = mongoDBOperations.SelectRecords<Book>("Books");
            dataGVD.DataSource = records;
        }

        private void RefreshButtonClick(object sender, EventArgs e)
        {
            RefreshDataGridViewCells();
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
