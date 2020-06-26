using LMS_160706300.MainMenu;
using System;
using System.Windows.Forms;

namespace LMS_160706300.Menus
{
    public partial class DatabaseOperations : Form
    {
        private bool navigate = false;

        public DatabaseOperations()
        {
            InitializeComponent();
        }

        private void prepareNavigate()
        {
            navigate = true;
            this.Close();
        }

        private void ReturnToHomeScreen(object sender, EventArgs e)
        {
            prepareNavigate();
            HomeScreen homeScreen = new HomeScreen();
            homeScreen.Show();
        }

        private void GoToAddPage(object sender, EventArgs e)
        {
            prepareNavigate();
            AddIntoLibrary addIntoLibrary = new AddIntoLibrary();
            addIntoLibrary.Show();
        }

        private void GoToDeletePage(object sender, EventArgs e)
        {
            prepareNavigate();
            DeleteFromLibrary deleteFromLibrary = new DeleteFromLibrary();
            deleteFromLibrary.Show();
        }

        private void GoToUpdatePage(object sender, EventArgs e)
        {
            prepareNavigate();
            UpdateFromLibrary updateFromLibrary = new UpdateFromLibrary();
            updateFromLibrary.Show();
        }

        private void DatabaseOperationsFormClosing(object sender, FormClosingEventArgs e)
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
            prepareNavigate();
            HomeScreen homeScreen = new HomeScreen();
            homeScreen.Show();
        }

        private void GoToBorrowPage(object sender, EventArgs e)
        {
            prepareNavigate();
            BorrowFromLibrary borrowFromLibrary = new BorrowFromLibrary();
            borrowFromLibrary.Show();
        }

        private void DatabaseOperations_FormClosed(object sender, FormClosedEventArgs e)
        {
        }
    }
}
