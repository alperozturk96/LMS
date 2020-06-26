using LMS_160706300.Core;
using System;
using System.Windows.Forms;

namespace LMS_160706300.Menus
{
    public partial class ReportScreen : Form
    {
        private bool navigate = false;
        private readonly Superintend superintend;

        public ReportScreen()
        {
            InitializeComponent();

            Form materialForm = this;
            superintend = new Superintend(materialForm);
        }



        private void GoToBookScreen(object sender, EventArgs e)
        {
            navigate = true;
            superintend.PrepareForNavigation(this, navigate);
            Menus.Books listedBooks = new Menus.Books();
            listedBooks.Show();
        }

        private void ReportScreen_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (navigate)
            {

            }
            else
            {
                DialogResult dialog = new DialogResult();

                dialog = MessageBox.Show("Do you want to close application ? ", "Alert!", MessageBoxButtons.YesNo);

                if (dialog == DialogResult.Yes)
                {
                    Environment.Exit(1);
                }
                else
                {
                    e.Cancel = true;
                }
            }
        }

        private void BackToHomeScreen(object sender, EventArgs e)
        {
            navigate = true;
            superintend.PrepareForNavigation(this, navigate);
            HomeScreen homeScreen = new HomeScreen();
            homeScreen.Show();
        }

        private void GoToBookBorrowersScreen(object sender, EventArgs e)
        {
            navigate = true;
            superintend.PrepareForNavigation(this, navigate);
            Menus.BookBorrowers bookBorrowers = new Menus.BookBorrowers();
            bookBorrowers.Show();
        }
    }
}

