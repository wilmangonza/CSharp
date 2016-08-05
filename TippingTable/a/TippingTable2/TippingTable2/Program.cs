using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Chapter 5 exercise 10a
// Wilman Gonzales

namespace TippingTable2
{
    class Program
    {
        static void Main(string[] args)
        {
            // name variables
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

            //get info for tipping table

            System.Console.WriteLine("  Please enter lowest tipping percent. (.## format)");
            lowrate = System.Console.ReadLine();
            LOWRATE = Convert.ToDouble(lowrate);

            System.Console.WriteLine("  Please enter highest tipping percent. (.## format)");
            maxrate = System.Console.ReadLine();
            MAXRATE = Convert.ToDouble(maxrate);

            System.Console.WriteLine("  Please enter lowest possible restaurant bill.");
            lowdinner = System.Console.ReadLine();
            LOWDINNER = Convert.ToDouble(lowdinner);

            System.Console.WriteLine("  Please enter highest possible restaurant bill.");
            maxdinner = System.Console.ReadLine();
            MAXDINNER = Convert.ToDouble(maxdinner);

            System.Console.WriteLine();
            System.Console.Write("  Price");

            for (tipRate = LOWRATE; tipRate <= MAXRATE; tipRate += TIPSTEP)
                System.Console.Write("{0, 8}", tipRate.ToString("F"));
            System.Console.WriteLine();
            System.Console.WriteLine("----------------------------------------");

            tipRate = LOWRATE;

            while (LOWDINNER <= MAXDINNER)
            {
                System.Console.Write("{0, 8}", LOWDINNER.ToString("C"));

                while (tipRate <= MAXRATE)
                {
                    tip = LOWDINNER * tipRate;
                    System.Console.Write("{0, 8}", tip.ToString("F"));
                    tipRate += 0.05;
                }
                LOWDINNER += DINNERSTEP;
                tipRate = LOWRATE;
                System.Console.WriteLine();
            }
            System.Console.ReadLine();
        }
    }
}
