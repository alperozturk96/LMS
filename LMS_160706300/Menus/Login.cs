using LMS_160706300.Models;
using System;
using System.Windows.Forms;

namespace LMS_160706300.Menus
{
    public partial class Login : Form
    {
        public static string loggedUserID;
        public static string loggedUserName;
        public static string loggedUserSurname;
        public static int borrowedBookCount;
        public static string[] borrowedBookNames;
        public Login()
        {
            InitializeComponent();
        }

        private bool CheckTextBoxFields()
        {
            if (textBoxEmail.Text == "")
            {
                MessageBox.Show("Please enter user name.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBoxEmail.Focus();
                return false;
            }
            if (textBoxPassword.Text == "")
            {
                MessageBox.Show("Please enter password.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBoxPassword.Focus();
                return false;
            }
            if (textBoxPassword.TextLength < 8)
            {
                MessageBox.Show("Password size must be more than 8 character.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBoxPassword.Focus();
                return false;
            }
            else
                return true;
        }

        [Obsolete]
        private void LoginIntoLMS(object sender, EventArgs e)
        {
            if (CheckTextBoxFields())
            {
                MongoDBOperations db = new MongoDBOperations();
                var usercollection = db.SelectRecords<User>("Users");

                bool successValue = false;

                foreach (var records in usercollection)
                {
                    if (textBoxEmail.Text.Equals(records.Email) && textBoxPassword.Text.Equals(records.Password))
                    {
                        this.Hide();
                        HomeScreen homeScreen = new HomeScreen();
                        homeScreen.Show();

                        loggedUserID = records.UserID.ToString();
                        loggedUserName = records.Name;
                        loggedUserSurname = records.Surname;
                        borrowedBookNames = records.Borrow.BorrowedBookName;
                        borrowedBookCount = records.BorrowedBookCount;

                        successValue = true;
                    }
                }

                if (successValue)
                {
                    MessageBox.Show("User succesfully logged in LMS System.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                    MessageBox.Show("User e-mail or password is not correct.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void SignUp(object sender, EventArgs e)
        {
            this.Hide();
            SignUpScreen signUpScreen = new SignUpScreen();
            signUpScreen.Show();
        }

        private void LoginFormClosing(object sender, FormClosingEventArgs e)
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
