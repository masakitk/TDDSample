using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TddFizzBuzz
{
    public partial class FizzBuzzForm : Form
    {
        public FizzBuzzForm()
        {
            InitializeComponent();
        }

        private void fizzBuzzButton_Click(object sender, EventArgs e)
        {
            if (!IsMoreThanZero(maxNumberTextBox.Text))
            {
                MessageBox.Show("1以上の数値を入力してください。");
                return;
            }
            fizzBuzzDataGridView.ShowFizzBuzzRows(int.Parse(maxNumberTextBox.Text));
        }

        private bool IsMoreThanZero(string text)
        {
            int number;
            if(!int.TryParse(text, out number)) return false;
            if (number <= 0) return false;
            return true;
        }
    }
}
