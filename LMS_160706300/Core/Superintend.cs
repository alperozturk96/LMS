using LMS_160706300.Menus;
using LMS_160706300.Models;
using MaterialSkin.Controls;
using System;
using System.Windows.Forms;

namespace LMS_160706300.Core
{
    public class Superintend
    {
        private readonly Form materialForm;

        public Superintend(Form mF)
        {
            materialForm = mF;
        }

        public void FetchCurrentValuesFromDB(string loggedUserName, string loggedUserSurname)
        {
            MongoDBOperations db = new MongoDBOperations();
            var usercollection = db.SelectRecords<User>("Users");

            foreach (var records in usercollection)
            {
                if (loggedUserName.Equals(records.Email) && loggedUserSurname.Equals(records.Password))
                {
                    Login.borrowedBookNames = records.Borrow.BorrowedBookName;
                    Login.borrowedBookCount = records.BorrowedBookCount;
                }
            }
        }

        public void PrepareForNavigation(Form mF, bool navigate)
        {
            try
            {
                mF.Close();
            }
            catch (Exception)
            {

                throw;
            }
        }

        public void FormClosing(FormClosingEventArgs e, bool navigate)
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

        public bool ControlInputValuesForDeleteOperations()
        {
            int number = -1;

            if (int.TryParse(materialForm.Controls["textBoxTitle"].Text, out number))
            {
                MessageBox.Show("Please not enter a number value for Title section.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                materialForm.Controls["textBoxTitle"].Focus();
                return false;
            }

            else
                return true;
        }

        public bool ControlTextBoxesForDeleteOperations()
        {
            if (materialForm.Controls["textBoxTitle"].Text == "")
            {
                MessageBox.Show("Please enter title of book.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                materialForm.Controls["textBoxTitle"].Focus();
                return false;
            }
            if (materialForm.Controls["textBoxEdition"].Text == "")
            {
                MessageBox.Show("Please enter edition number of book.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                materialForm.Controls["textBoxEdition"].Focus();
                return false;
            }
            else
                return true;
        }

        public bool ControlTextBoxesForSignUpPart1()
        {
            if (materialForm.Controls["textBoxName"].Text == "")
            {
                MessageBox.Show("Please enter name of user.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                materialForm.Controls["textBoxName"].Focus();
                return false;
            }
            if (materialForm.Controls["textBoxSurname"].Text == "")
            {
                MessageBox.Show("Please enter surname of user.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                materialForm.Controls["textBoxSurName"].Focus();
                return false;
            }
            if (materialForm.Controls["textBoxEmail"].Text == "")
            {
                MessageBox.Show("Please enter e-mail address of user.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                materialForm.Controls["textBoxEmail"].Focus();
                return false;
            }

            else
                return true;
        }

        public bool ControlTextBoxesForSignUpPart2()
        {
            if (materialForm.Controls["textBoxAge"].Text == "")
            {
                MessageBox.Show("Please enter age of user.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                materialForm.Controls["textBoxAge"].Focus();
                return false;
            }
            if (materialForm.Controls["textBoxPassword"].Text.Length < 8)
            {
                MessageBox.Show("Minimum password size is 8.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                materialForm.Controls["textBoxPassword"].Focus();
                return false;
            }
            if (!materialForm.Controls["textBoxPasswordRepeat"].Text.Equals(materialForm.Controls["textBoxPassword"].Text))
            {
                MessageBox.Show("Please confirm your password.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                materialForm.Controls["textBoxPasswordRepeat"].Focus();
                return false;
            }
            else
                return true;
        }




        public bool ControlTextBoxesForSignUp()
        {
            if (!ControlTextBoxesForSignUpPart1())
            {
                return false;
            }
            else if (!ControlTextBoxesForSignUpPart2())
            {
                return false;
            }
            else
                return true;
        }

        public bool ControlInputValuesForSignUp()
        {
            int number = -1;
            if (int.TryParse(materialForm.Controls["textBoxName"].Text, out number))
            {
                MessageBox.Show("Please not enter a number value for NAME section.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                materialForm.Controls["textBoxName"].Focus();
                return false;
            }
            if (int.TryParse(materialForm.Controls["textBoxSurname"].Text, out number))
            {
                MessageBox.Show("Please not enter a number value for SURNAME section.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                materialForm.Controls["textBoxSurname"].Focus();
                return false;
            }
            if (int.TryParse(materialForm.Controls["textBoxEmail"].Text, out number))
            {
                MessageBox.Show("Please not enter a number for E-MAIL section.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                materialForm.Controls["textBoxEmail"].Focus();
                return false;
            }
            if (!int.TryParse(materialForm.Controls["textBoxAge"].Text, out number))
            {
                MessageBox.Show("Please enter a number value for AGE section.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                materialForm.Controls["textBoxAge"].Focus();
                return false;
            }
            else
                return true;
        }

        public bool ControlInputValuesPart1()
        {
            int number = -1;
            if (!int.TryParse(materialForm.Controls["textBoxYear"].Text, out number))
            {
                MessageBox.Show("Please enter a number value for YEAR section.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                materialForm.Controls["textBoxYear"].Focus();
                return false;
            }
            if (!int.TryParse(materialForm.Controls["textBoxQuantity"].Text, out number))
            {
                MessageBox.Show("Please enter a number value for Quantity section.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                materialForm.Controls["textBoxQuantity"].Focus();
                return false;
            }
            if (materialForm.Controls["textBoxISBN"].Text.Length != 13)
            {
                MessageBox.Show("ISBN number must be equal 13.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                materialForm.Controls["textBoxISBN"].Focus();
                return false;
            }
            if (!int.TryParse(materialForm.Controls["textBoxBorrowedBooks"].Text, out number))
            {
                MessageBox.Show("Please enter a number value for Borrowed Book section.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                materialForm.Controls["textBoxBorrowedBooks"].Focus();
                return false;
            }
            else
                return true;
        }

        public bool ControlInputValuesPart2()
        {
            int number = -1;
            if (int.TryParse(materialForm.Controls["textBoxTitle"].Text, out number))
            {
                MessageBox.Show("Please not enter a number value for Title section.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                materialForm.Controls["textBoxTitle"].Focus();
                return false;
            }
            if (int.TryParse(materialForm.Controls["textBoxAuthor"].Text, out number))
            {
                MessageBox.Show("Please not enter a number value for Author section.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                materialForm.Controls["textBoxAuthor"].Focus();
                return false;
            }

            if (int.TryParse(materialForm.Controls["textBoxPublisher"].Text, out number))
            {
                MessageBox.Show("Please not enter a number value for Publisher section.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                materialForm.Controls["textBoxPublisher"].Focus();
                return false;
            }
            else
                return true;
        }

        public bool ControlInputValues()
        {
            if (!ControlInputValuesPart1())
            {
                return false;
            }
            else if (!ControlInputValuesPart1())
            {
                return false;
            }
            else
                return true;
        }

        public void ClearForm()
        {
            try
            {
                foreach (Control control in materialForm.Controls)
                {
                    if (control.GetType() == typeof(MaterialSingleLineTextField))
                    {
                        control.Text = "";
                    }
                }
            }
            catch (Exception)
            {

                throw;
            }
        }


        public bool ControlTextBoxesPart1()
        {
            if (materialForm.Controls["textBoxTitle"].Text == "")
            {
                MessageBox.Show("Please enter title of book.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                materialForm.Controls["textBoxTitle"].Focus();
                return false;
            }
            if (materialForm.Controls["textBoxAuthor"].Text == "")
            {
                MessageBox.Show("Please enter author of book.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                materialForm.Controls["textBoxAuthor"].Focus();
                return false;
            }
            if (materialForm.Controls["textBoxISBN"].Text == "")
            {
                MessageBox.Show("Please enter ISBN number.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                materialForm.Controls["textBoxISBN"].Focus();
                return false;
            }
            if (materialForm.Controls["textBoxEdition"].Text == "")
            {
                MessageBox.Show("Please enter edition number of book.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                materialForm.Controls["textBoxEdition"].Focus();
                return false;
            }
            else
                return true;
        }

        public bool ControlTextBoxesPart2()
        {
            if (materialForm.Controls["textBoxBorrowedBooks"].Text == "")
            {
                MessageBox.Show("Please how many book borrowed.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                materialForm.Controls["textBoxBorrowedBooks"].Focus();
                return false;
            }
            if (materialForm.Controls["textBoxQuantity"].Text == "")
            {
                MessageBox.Show("Please enter quantity number of book.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                materialForm.Controls["textBoxQuantity"].Focus();
                return false;
            }
            if (materialForm.Controls["textBoxPublisher"].Text == "")
            {
                MessageBox.Show("Please enter publisher of book.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                materialForm.Controls["textBoxPublisher"].Focus();
                return false;
            }
            if (materialForm.Controls["textBoxYear"].Text == "")
            {
                MessageBox.Show("Please enter which year book published.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                materialForm.Controls["textBoxYear"].Focus();
                return false;
            }
            else
                return true;
        }

        public bool ControlTextBoxes()
        {
            if (!ControlTextBoxesPart1())
            {
                return false;
            }
            else if (!ControlTextBoxesPart2())
            {
                return false;
            }
            else
                return true;
        }
    }
}
