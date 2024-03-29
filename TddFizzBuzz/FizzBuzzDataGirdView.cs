﻿using System.Windows.Forms;

namespace TddFizzBuzz
{
    public partial class FizzBuzzDataGirdView : DataGridView
    {
        public FizzBuzzDataGirdView()
        {
            InitializeComponent();
        }

        internal void ShowFizzBuzzRows(int maxNumber)
        {
            DataSource = FizzBuzzService.GetInstance().GetFizzBuzzList(maxNumber); 
        }
    }
}
