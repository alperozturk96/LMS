using LMS_160706300.Core;
using LMS_160706300.Models;
using System;
using System.Windows.Forms;

namespace LMS_160706300.Menus
{
    public partial class Books : Form
    {
        private readonly Superintend superintend;
        private bool navigate = false;
        private readonly MongoDBOperations mongoDBOperations = new MongoDBOperations();
        public Books()
        {
            InitializeComponent();

            Form materialForm = this;
            superintend = new Superintend(materialForm);
        }

        private void ListedBooksLoad(object sender, EventArgs e)
        {
            var records = mongoDBOperations.SelectRecords<Book>("Books");
            dataGVListedBooks.DataSource = records;
        }

        private void BookListFormClosing(object sender, FormClosingEventArgs e)
        {
            superintend.FormClosing(e, navigate);
        }

        [Obsolete]
        private void ShowUsersWhoBorrowBooks(object sender, EventArgs e)
        {
            var bookBorrowersList = mongoDBOperations.SelectRecords<BookBorrowers>("Book Borrowers");
            dataGVListedBooks.DataSource = bookBorrowersList;
        }

        private void BackToReportScreen(object sender, EventArgs e)
        {
            navigate = true;
            superintend.PrepareForNavigation(this, navigate);
            HomeScreen homeScreen = new HomeScreen();
            homeScreen.Show();
        }
    }
}
