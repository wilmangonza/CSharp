using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// Chapter 6 exercise 9
// Wilman Gonzales

namespace Commission
{
    class Program
    {
        static void Main(string[] args)
        {
            // variables
            decimal saleAmount = 0.0M;
            decimal commission = 0.0M;
            decimal total = 0.0M;

            Console.WriteLine("-----------------------------------------Get salesteam Commission--------------------------------------");
            Console.WriteLine("Please enter car sales amount:");

            // calculations

            saleAmount = Convert.ToDecimal(Console.ReadLine());

            if (saleAmount <= 15000)
            {
                commission = 0.05M;
            }
            else if (saleAmount > 15000 && saleAmount <= 24000)
            {
                commission = 0.07M;
            }
            else
            {
                commission = 0.10M;
            }

            // CommissionCalc(saleAmount);
            total = saleAmount * commission;
            Console.Write("The total commission for that sales person is {0}", total);
            Console.ReadKey();
        }


    }
}
