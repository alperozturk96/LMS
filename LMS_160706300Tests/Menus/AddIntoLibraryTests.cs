using MaterialSkin.Controls;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Windows.Forms;

namespace LMS_160706300.MainMenu.Tests
{
    [TestClass()]
    public class AddIntoLibraryTests
    {
        private readonly AddIntoLibrary addIntoLibrary = new AddIntoLibrary();

        [TestMethod()]
        public void CheckFieldsEmptyOrNot()
        {
            foreach (Control i in addIntoLibrary.Controls)
            {
                if (i.GetType() == typeof(MaterialSingleLineTextField))
                {
                    Assert.AreEqual("", i.Text);
                }
            }
        }

        [TestMethod()]
        public bool CheckFieldIntegerOrNot()
        {
            int number = -1;
            if (!int.TryParse(addIntoLibrary.Controls["textBoxQuantity"].Text, out number))
            {
                Assert.Fail("Please enter a number value for Quantity section.");
                return false;
            }
            if (!int.TryParse(addIntoLibrary.Controls["textBoxYear"].Text, out number))
            {
                Assert.Fail("Please enter a number value for Year section.");
                return false;
            }
            if (!int.TryParse(addIntoLibrary.Controls["textBoxBorrowedBooks"].Text, out number))
            {
                Assert.Fail("Please enter a number value for Borrowed Books section.");
                return false;
            }
            if (int.TryParse(addIntoLibrary.Controls["textBoxTitle"].Text, out number))
            {
                Assert.Fail("Please not enter a number value for Title section.");
                return false;
            }
            if (int.TryParse(addIntoLibrary.Controls["textBoxAuthor"].Text, out number))
            {
                Assert.Fail("Please not enter a number value for Author section.");
                return false;
            }
            if (int.TryParse(addIntoLibrary.Controls["textBoxEdition"].Text, out number))
            {
                Assert.Fail("Please not enter a number value for Edition section.");
                return false;
            }
            if (int.TryParse(addIntoLibrary.Controls["textBoxPublisher"].Text, out number))
            {
                Assert.Fail("Please not enter a number value for Publisher section.");
                return false;
            }
            else
                return true;
        }

        [TestMethod()]
        public void ISBNLengthTest()
        {
            if (addIntoLibrary.Controls["textBoxISBN"].Text.Length != 13)
            {
                Assert.Fail("Entered password less than minimum size.");
            }
        }
    }
}