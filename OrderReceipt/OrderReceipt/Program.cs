using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


// Chapter 2 Exercise 14
// Developer: Wilman Gonzales

namespace OrderReceipt
{
    class Program
    {
        static void Main(string[] args)
        {
            string name;
            string street_address;
            string city;
            string state;
            int zipcode;
            int Quantity;
            double amount_before_tax;
            double sales_tax;
            double net_due;
            double cost = 39.95;

            /*

            This will get the info we need to calculate
            customer info

            */

            Console.Write("Please Enter the Name : ");
            name = Console.ReadLine();
            Console.Write("Please Enter the Street Address  : ");
            street_address = Console.ReadLine();
            Console.Write("Please Enter the name of City : ");
            city = Console.ReadLine();
            Console.Write("Please Enter the name of State : ");
            state = Console.ReadLine();
            Console.Write("Please Enter the Zipcode : ");
            zipcode = Convert.ToInt32(Console.ReadLine());
            Console.Write("Please Enter the Quantity Value : ");
            Quantity = Convert.ToInt32(Console.ReadLine());

            //The Calculation Part
            amount_before_tax = Quantity * cost;
            sales_tax = amount_before_tax * 0.07;
            net_due = amount_before_tax + sales_tax;

            // This will Display the Result
            Console.WriteLine();
            Console.WriteLine("-------------------------------------------------");
            Console.WriteLine("--------------------- OUTPUT --------------------");
            Console.WriteLine("-------------------------------------------------");
            Console.WriteLine("Name : {0}", name);
            Console.WriteLine("Street Address : {0}", street_address);
            Console.WriteLine("City : {0}", city);
            Console.WriteLine("State : {0}", state);
            Console.WriteLine("Zip Code : {0}", zipcode);
            Console.WriteLine("Quantity Ordered : {0}", Quantity);
            Console.WriteLine("Amount Before Tax : ${0}", amount_before_tax);
            Console.WriteLine("Sales Tax Amount : ${0}", sales_tax);
            Console.WriteLine("Net Due Amount : ${0}", net_due);

            Console.WriteLine();
            Console.WriteLine("Press Any Key to Terminate the Program..");
            Console.ReadLine();
        }
    }

}

