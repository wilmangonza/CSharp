using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
// CHAPTER 5 EXERCISE 10b
// Wilman Gonzales

namespace TippingTable2GUI
{
    public partial class Form1 : Form

    {
        double tipRate;
        double tip;
        double LOWRATE;
        double MAXRATE;
        const double TIPSTEP = 0.05;
        double LOWDINNER;
        double MAXDINNER;
        const double DINNERSTEP = 10.00;
        string lowrate;
        string maxrate;
        string lowdinner;
        string maxdinner;



        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            lowrate = textBox1.Text;
            LOWRATE = Convert.ToDouble(lowrate);

            maxrate = textBox2.Text;
            MAXRATE = Convert.ToDouble(maxrate);

            lowdinner = textBox3.Text;
            LOWDINNER = Convert.ToDouble(lowdinner);

            maxdinner = textBox4.Text;
            MAXDINNER = Convert.ToDouble(maxdinner);
 
           for (tipRate = LOWRATE; tipRate<= MAXRATE; tipRate += TIPSTEP)
                label5.Text = String.Format( "{0,8}", tipRate.ToString("F"));

            tipRate = LOWRATE;

            while (LOWDINNER <= MAXDINNER)
            {
                label6.Text = String.Format( "{0, 8}", LOWDINNER.ToString("C"));
                while (tipRate <= MAXRATE)
                {
                    tip = LOWDINNER * tipRate;
                    label7.Text = String.Format("{0, 8}", tip.ToString("F"));
                    tipRate += 0.05; 

                }
                LOWDINNER += DINNERSTEP;
                tipRate = LOWRATE;


            }


        }
    }
}
