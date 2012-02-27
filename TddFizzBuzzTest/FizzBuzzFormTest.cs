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

            var expectedList = new[] {
                new { Number = 1, Text = "1" },
                new { Number = 2, Text = "2" },
                new { Number = 3, Text = "Fizz" },
                new { Number = 4, Text = "4" },
                new { Number = 5, Text = "Buzz" },
                new { Number = 6, Text = "Fizz" },
                new { Number = 7, Text = "7" },
                new { Number = 8, Text = "8" },
                new { Number = 9, Text = "Fizz" },
                new { Number = 10, Text = "Buzz" },
            };

            foreach (var expected in expectedList)
                AssertForOneRow(dataGrid, expected.Number, expected.Text);
        }

        [Test]
        public void Test02_数値以外の入力時をチェックしているか()
        {
            バリデーションメッセージ確認("aaa", "1以上の数値を入力してください。");
            バリデーションメッセージ確認("01a", "1以上の数値を入力してください。");
        }

        [Test]
        public void Test03_0以下の入力時をチェックしているか()
        {
            バリデーションメッセージ確認("0", "1以上の数値を入力してください。");
            バリデーションメッセージ確認("-3", "1以上の数値を入力してください。");
        }

        private void バリデーションメッセージ確認(string text, string message)
        {
            var target = new FizzBuzzForm();
            target.Show();

            DialogBoxHandler = (title, handle) =>
            {
                var messageBox = new MessageBoxTester(handle);
                Assert.That(messageBox.Text, Is.EqualTo(message));
                messageBox.ClickOk();
            };

            new TextBoxTester("maxNumberTextBox", target).Enter(text);
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
