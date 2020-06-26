using LMS_160706300.Menus;
using System;
using System.Windows.Forms;

namespace LMS_160706300
{
    public partial class HomeScreen : Form
    {
        public HomeScreen()
        {
            InitializeComponent();
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            this.Hide();
            SearchFromLibrary searchFromLibrary = new SearchFromLibrary();
            searchFromLibrary.Show();
        }

        private void buttonDB_Click(object sender, EventArgs e)
        {
            this.Hide();
            DatabaseOperations databaseOperations = new DatabaseOperations();
            databaseOperations.Show();
        }

        private void ReportScreen(object sender, EventArgs e)
        {
            this.Hide();
            ReportScreen reportScreen = new ReportScreen();
            reportScreen.Show();
        }

        private void HomeScreen_FormClosing(object sender, FormClosingEventArgs e)
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
}
