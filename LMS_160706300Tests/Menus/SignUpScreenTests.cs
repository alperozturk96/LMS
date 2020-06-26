using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Windows.Forms;

namespace LMS_160706300.Menus.Tests
{
    [TestClass()]
    public class SignUpScreenTests
    {
        private readonly SignUpScreen signUpScreen = new SignUpScreen();

        [TestMethod()]
        public void CheckFieldsEmptyOrNot()
        {
            foreach (Control i in signUpScreen.Controls)
            {
                if (i.GetType() == typeof(TextBox))
                {
                    Assert.AreEqual("", i.Text);
                }
            }
        }

        [TestMethod()]
        public bool CheckFieldIntegerOrNot()
        {
            int number = -1;
            if (!int.TryParse(signUpScreen.Controls["textBoxAge"].Text, out number))
            {
                Assert.Fail("Please enter a number value for Age section.");
                return false;
            }
            if (int.TryParse(signUpScreen.Controls["textBoxSurname"].Text, out number))
            {
                Assert.Fail("Please not enter a number value for Surname section.");
                return false;
            }
            if (int.TryParse(signUpScreen.Controls["textBoxName"].Text, out number))
            {
                Assert.Fail("Please not enter a number value for Name section.");
                return false;
            }
            else
                return true;
        }

        [TestMethod()]
        public void PasswordLengthTest()
        {
            if (signUpScreen.Controls["textBoxPassword"].Text.Length < 8)
            {
                Assert.Fail("Entered password less than minimum size.");
            }
        }

        [TestMethod()]
        public void EmailAddressTest()
        {
            string emailSign = "@";

            if (!signUpScreen.Controls["textBoxEmail"].Text.Contains(emailSign))
            {
                Assert.Fail("Entered email address is not valid.");
            }


        }

        [TestMethod()]
        public void PasswordMatchTest()
        {
            if (signUpScreen.Controls["textBoxPassword"].Text != signUpScreen.Controls["textBoxPasswordRepeat"].Text)
            {
                Assert.Fail("Entered password is not matching.");
            }
        }
    }
}