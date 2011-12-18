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
            fizzBuzzDataGridView.ShowFizzBuzzRows(int.Parse(maxNumberTextBox.Text));
        }
    }
}
