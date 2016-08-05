using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;




// CHAPTER 4 EXERCISE 9b
// Wilman Gonzales

namespace LotteryGUI
{
    public partial class Form1 : Form
    {
        private int[] iGuesses = new int[3]; // declared at form level
        private int[] iSortedGuesses = new int[3]; 

        public Form1()
        {
            InitializeComponent();
        }



        private void textBox1_Leave(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                MessageBox.Show("You haven't chosen your first number yet");
                textBox1.Focus();
                return;
            }

            int iGuess;
            int.TryParse(textBox1.Text, out iGuess);

            if (iGuess < 1 || iGuess > 4)
            {
                MessageBox.Show("You have entered an incorrect number please try again");
                textBox1.Focus();
                return;
            }

            iGuesses[0] = iGuess;
            iSortedGuesses[0] = iGuess;

        }

        private void textBox2_Leave(object sender, EventArgs e)
        {
            if (textBox2.Text == "")
            {
                MessageBox.Show("You haven't chosen your second number yet");
                textBox2.Focus();
                return;
            }

            int iGuess;
            int.TryParse(textBox2.Text, out iGuess);

            if (iGuess < 1 || iGuess > 4)
            {
                MessageBox.Show("You have entered an incorrect number please try again");
                textBox2.Focus();
                return;
            }

            iGuesses[1] = iGuess;
            iSortedGuesses[1] = iGuess;
        }

        private void textBox3_Leave(object sender, EventArgs e)
        {
            if (textBox3.Text == "")
            {
                MessageBox.Show("You haven't chosen your third number yet");
                textBox3.Focus();
                return;
            }

            int iGuess;
            int.TryParse(textBox3.Text, out iGuess);

            if (iGuess < 1 || iGuess > 4)
            {
                MessageBox.Show("You have entered an incorrect number please try again");
                textBox3.Focus();
                return;
            }

            iGuesses[2] = iGuess;
            iSortedGuesses[2] = iGuess;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "")
            {
                MessageBox.Show("You haven't yet chosen three numbers");
                return;
            }

            // declaring variables integer type

            int iNum1;
            int iNum2;
            int iNum3;

            // declaring the constants

            const int iMATCHONE = 10;
            const int iMATCHTWO = 100;
            const int iMATCHTHREE = 1000;
            const int iMATCHFOUR = 10000;

            // declaring array

            int[] iSortedNums = new int[3];

            // generating random numbers

            Random randomnumber = new Random();

            iNum1 = randomnumber.Next(1, 5); // number between 1 and 4
            iNum2 = randomnumber.Next(1, 5);
            iNum3 = randomnumber.Next(1, 5);
            iSortedNums[0] = iNum1;
            iSortedNums[1] = iNum2;
            iSortedNums[2] = iNum3;
            Array.Sort(iSortedNums); // sort random numbers
            Array.Sort(iSortedGuesses); // sort the guesses             

            label4.Text = String.Format("The random numbers are    : " + iNum1 + ", " + iNum2 + ", " + iNum3);
            label5.Text = String.Format("The numbers you chose are : " + iGuesses[0] + ", " + iGuesses[1] + ", " + iGuesses[2]);

            if (iGuesses[0] == iNum1 && iGuesses[1] == iNum2 && iGuesses[2] == iNum3)
            {
                MessageBox.Show("you won $" + iMATCHFOUR);
            }

            else if (iSortedGuesses[0] == iSortedNums[0] && iSortedGuesses[1] == iSortedNums[1]
            && iSortedGuesses[2] == iSortedNums[2])
            {
                MessageBox.Show("you won $" + iMATCHTHREE);
            }

            else if ((iGuesses[0] == iNum1 && iGuesses[1] == iNum2) || (iGuesses[1] == iNum2 && iGuesses[2] == iNum3))
            {
                MessageBox.Show("you won $" + iMATCHTWO);
            }

            else if (iGuesses[0] == iNum1 || iGuesses[1] == iNum2 || iGuesses[2] == iNum3)
            {
                MessageBox.Show("you won $" + iMATCHONE);
            }

            else
            {
                MessageBox.Show("sorry, you didn't win anything");
            }
        }
    }
}
