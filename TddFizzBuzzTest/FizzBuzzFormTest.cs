using System.Windows.Forms;
using NUnit.Extensions.Forms;
using NUnit.Framework;
using TddFizzBuzz;

namespace TddFizzBuzzTest
{
    [TestFixture]
    public class TddFizzBuzzTest : NUnitFormTest
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
            AssertForOneRow(dataGrid, 2, "2");
            AssertForOneRow(dataGrid, 3, "Fizz");
            AssertForOneRow(dataGrid, 4, "4");
            AssertForOneRow(dataGrid, 5, "Buzz");
            AssertForOneRow(dataGrid, 6, "Fizz");
            AssertForOneRow(dataGrid, 7, "7");
            AssertForOneRow(dataGrid, 8, "8");
            AssertForOneRow(dataGrid, 9, "Fizz");
            AssertForOneRow(dataGrid, 10, "Buzz");
        }
        [Test]
        public void Test02_数値以外の入力時をチェックしているか()
        {
            var target = new FizzBuzzForm();
            target.Show();

            DialogBoxHandler = (title, handle) =>
            {
                var messageBox = new MessageBoxTester(handle);
                Assert.That(messageBox.Text, Is.EqualTo("1以上の数値を入力してください。"));
                messageBox.ClickOk();
            };

            new TextBoxTester("maxNumberTextBox", target).Enter("aaa");
            new ButtonTester("fizzBuzzButton", target).Click();
        }


        private static void AssertForOneRow(DataGridView dataGrid, int rowIndex, string expected)
        {
            Assert.That(dataGrid["FizzBuzzValue", ToZeroBased(rowIndex)].Value, Is.EqualTo(expected));
        }

        private static int ToZeroBased(int rowIndex)
        {
            return rowIndex - 1;
        }
    }
}
