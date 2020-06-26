using MaterialSkin.Controls;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Windows.Forms;

namespace LMS_160706300.Menus.Tests
{
    [TestClass()]
    public class DeleteFromLibraryTests
    {
        private readonly DeleteFromLibrary deleteFromLibrary = new DeleteFromLibrary();
        public void CheckFieldsEmptyOrNot()
        {
            foreach (Control i in deleteFromLibrary.Controls)
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
            if (int.TryParse(deleteFromLibrary.Controls["textBoxTitle"].Text, out number))
            {
                Assert.Fail("Please not enter a number value for Title section.");
                return false;
            }
            if (int.TryParse(deleteFromLibrary.Controls["textBoxEdition"].Text, out number))
            {
                Assert.Fail("Please not enter a number value for Edition section.");
                return false;
            }
            else
                return true;
        }
    }
}