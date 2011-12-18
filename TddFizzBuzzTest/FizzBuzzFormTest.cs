using System.Windows.Forms;
using NUnit.Extensions.Forms;
using NUnit.Framework;
using TddFizzBuzz;

namespace TddFizzBuzzTest
{
    [TestFixture]
    public class TddFizzBuzzTest
    {
        [Test]
        public void Test01_10までのFizzBuzz結果の確認()
        {
            var target = new FizzBuzzForm();
            target.Show();

            new TextBoxTester("maxNumberTextBox", target).Enter("10");
            new ButtonTester("fizzBuzzButton", target).Click();
            var dataGrid = new Finder<DataGridView>("fizzBuzzDataGridView", target).Find();
            AssertForOneRow(dataGrid, 1, "1");
        }

        private static void AssertForOneRow(DataGridView dataGrid, int rowIndex, string expected)
        {
            Assert.That(dataGrid["FizzBuzzValue", rowIndex].Value, Is.EqualTo(expected));
        }
    }
}
