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
            AssertForOneRow(dataGrid, 1, "2");
            AssertForOneRow(dataGrid, 1, "Fizz");
            AssertForOneRow(dataGrid, 1, "4");
            AssertForOneRow(dataGrid, 1, "Buzz");
            AssertForOneRow(dataGrid, 1, "Fizz");
            AssertForOneRow(dataGrid, 1, "7");
            AssertForOneRow(dataGrid, 1, "8");
            AssertForOneRow(dataGrid, 1, "Fizz");
            AssertForOneRow(dataGrid, 1, "Buzz");
        }

        private static void AssertForOneRow(DataGridView dataGrid, int rowIndex, string expected)
        {
            Assert.That(dataGrid["FizzBuzzValue", rowIndex].Value, Is.EqualTo(expected));
        }
    }
}
