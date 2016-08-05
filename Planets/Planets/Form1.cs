using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


//Chapter 2 Exercise 16
//Developer Wilman Gonzales

namespace Planets
{
    public partial class Form1 : Form

    {
        // setting the enumeration
        enum Planet
        {
           Mercury = 1,
           Venus = 2,
           Earth = 3,
           Mars = 4,
           Jupiter = 5,
           Saturn = 6,
           Uranus= 7,
           Neptune = 8,
            
        };

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int planetNumber;
            int.TryParse(inputTextBox.Text, out planetNumber);
            if (planetNumber < 1 || planetNumber > 8)
            {
                MessageBox.Show("Please enter an integer between 1 and 8");
                inputTextBox.Focus();
                return;
            }
            string planetName = ((Planet)planetNumber).ToString();
            MessageBox.Show("You entered the planet number for " + planetName);
            inputTextBox.Clear();
            inputTextBox.Focus();
        }
    }
}
