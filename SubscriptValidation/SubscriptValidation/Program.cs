using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// Chapter 11 exercise 1
// Wilman Gonzales


namespace SubscriptValidation
{
    class Program
    {
        static void Main(string[] args)
        {
            int number;
            int[] numbers = new int[10] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            Console.WriteLine("Please enter a number from 1 to 10");

            try
            {
                number = Convert.ToInt32(Console.ReadLine());
                
                   if (number < 1 || number > 10) throw new IndexOutOfRangeException();
                Console.WriteLine("Your number is {0}", number);
                Console.ReadLine();

            }
            catch (IndexOutOfRangeException)
            {
                Console.WriteLine("Your number is out of range, Please enter a number from 1 to 10");
                Console.ReadLine();
            }
        }
    }
}
