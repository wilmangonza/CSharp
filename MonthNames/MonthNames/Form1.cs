using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

// Chapter 2 Exercise 15
// Developer Wilman Gonzales





namespace MonthNames
{
    public partial class Form1 : Form
    {
        // setting the enumeration

        enum Month
        {
            January = 1,
            February = 2,
            March = 3,
            April = 4,
            May = 5,
            June = 6,
            July = 7,
            August = 8,
            September = 9,
            October = 10,
            November = 11,
            December = 12
        };



        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int monthNumber;
            int.TryParse(inputTextBox.Text, out monthNumber);
            if (monthNumber < 1 || monthNumber > 12)
            {
                MessageBox.Show("Please enter an integer between 1 and 12");
                inputTextBox.Focus();
                return;
            }
            string monthName = ((Month)monthNumber).ToString();
            MessageBox.Show("You entered the month number for " + monthName);
            inputTextBox.Clear();
            inputTextBox.Focus();
        }
    }
}
