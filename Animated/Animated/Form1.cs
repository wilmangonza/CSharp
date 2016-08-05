using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//Chapter 13 Exercise 4
//Wilman Gonzales

namespace Animated
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox1_MouseEnter(object sender, EventArgs e)
        {
            label1.Text = "You are inside the image.";
        }

        private void pictureBox1_MouseLeave(object sender, EventArgs e)
        {
            label1.Text = "You are not inside the image.";
        }

        private void pictureBox1_MouseClick(object sender, MouseEventArgs e)
        {
            label1.Text = "You click the image.";
        }
    }
}
