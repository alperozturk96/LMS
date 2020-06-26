using LMS_160706300.Core;
using LMS_160706300.Models;
using System;
using System.Windows.Forms;

namespace LMS_160706300.Menus
{
    public partial class SignUpScreen : Form
    {
        private readonly Superintend superintend;
        private readonly bool navigate = false;

        public SignUpScreen()
        {
            InitializeComponent();

            Form materialForm = this;
            superintend = new Superintend(materialForm);
        }

        [Obsolete]
        private void CreateNewUser(object sender, EventArgs e)
        {
            try
            {
                if (superintend.ControlTextBoxesForSignUp() && superintend.ControlInputValuesForSignUp())
                {
                    MongoDBOperations db = new MongoDBOperations();
                    string[] initialBorrowedBookNameForNewUser = { "", "", "", "", "" };


                    db.InsertRecord("Users", new User
                    {
                        Name = textBoxName.Text,
                        Surname = textBoxSurname.Text,
                        Email = textBoxEmail.Text,
                        Age = Int32.Parse(textBoxAge.Text),
                        Password = textBoxPassword.Text,
                        BorrowedBookCount = 0,
                        Borrow = new UserNestedFields { LoanDate = "", LoanExpireDate = "", BorrowedBookName = initialBorrowedBookNameForNewUser }

                    });

                    MessageBox.Show("New user succesfully added into system.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
            }
            catch (Exception t)
            {
                MessageBox.Show(t.Message);
            }

        }

        private void ClearTextBoxes(object sender, EventArgs e)
        {
            superintend.ClearForm();
        }

        private void SignUpScreenFormClosing(object sender, FormClosingEventArgs e)
        {
            superintend.FormClosing(e, navigate);
        }

        private void BackHomeScreen(object sender, EventArgs e)
        {
            this.Hide();
            Login login = new Login();
            login.Show();
        }
    }
}
