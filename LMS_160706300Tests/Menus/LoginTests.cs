using MaterialSkin.Controls;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Windows.Forms;

namespace LMS_160706300.Menus.Tests
{
    [TestClass()]
    public class LoginTests
    {
        private readonly Login login = new Login();
        [TestMethod()]
        public void CheckFieldsEmptyOrNot()
        {
            foreach (Control i in login.Controls)
            {
                if (i.GetType() == typeof(MaterialSingleLineTextField))
                {
                    Assert.AreEqual("", i.Text);
                }
            }
        }
        [TestMethod()]
        public void PasswordLengthTest()
        {
            if (login.Controls["textBoxPassword"].Text.Length < 8)
            {
                Assert.Fail("Entered password less than minimum size.");
            }
        }
        [TestMethod()]
        public void EmailAddressTest()
        {
            string emailSign = "@";

            if (!login.Controls["textBoxEmail"].Text.Contains(emailSign))
            {
                Assert.Fail("Entered email address is not valid.");
            }
        }

    }
}