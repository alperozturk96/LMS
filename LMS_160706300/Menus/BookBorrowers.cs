using LMS_160706300.Core;
using LMS_160706300.Models;
using System;
using System.Windows.Forms;

namespace LMS_160706300.Menus
{
    public partial class BookBorrowers : Form
    {
        private readonly Superintend superintend;
        private bool navigate = false;
        private readonly MongoDBOperations mongoDBOperations = new MongoDBOperations();

        public BookBorrowers()
        {
            InitializeComponent();

            Form materialForm = this;
            superintend = new Superintend(materialForm);
        }

        private void BackToReportScreen(object sender, EventArgs e)
        {
            navigate = true;
            superintend.PrepareForNavigation(this, navigate);
            ReportScreen reportScreen = new ReportScreen();
            reportScreen.Show();
        }

        [Obsolete]
        private void BookBorrowersFormLoad(object sender, EventArgs e)
        {
            var bookBorrowersList = mongoDBOperations.SelectSpecificUserRecords();
            dataGVListedBooks.DataSource = bookBorrowersList;
        }

        private void BookBorrowersFormClosing(object sender, FormClosingEventArgs e)
        {
            superintend.FormClosing(e, navigate);
        }
    }
}
