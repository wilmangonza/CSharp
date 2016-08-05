using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// CHAPTER 9 EXERCISE 9b
// WILMAN GONZALES

namespace FriendBirthday
{
    class Program
    {
        public static void Main()
        {
            Friend[] friend = new Friend[8];
            // these are the variables

            string name;
            string phone;
            int month;
            int day;
            int year;
            int x;

            for (x = 0; x < friend.Length; ++x)
            {
                GetData(out name, out phone, out month, out day, out year);
                friend[x] = new Friend(name, phone, month, day, year);
            }

            Array.Sort(friend);
            Console.WriteLine("\nSorted List:");
            Console.WriteLine("  Name \t\t  Phone Number \tDOB Month/Day/Year");
            for (x = 0; x < friend.Length; ++x)
                Display(friend[x]);

            /* after the requested Friend’s birthday displays 
            the program also displays a list
            of every Friend who has a birthday 
            in the same month. */

            Friend seekFrn = new Friend();
            Console.Write("\nEnter a specific friend's name for their phone number and birthday, or type 'quit' to exit:");
            seekFrn.Name = Console.ReadLine();

            while (seekFrn.Name != "quit")
            {
                Array.Sort(friend);
                x = Array.BinarySearch(friend, seekFrn);
                if (x < 0)
                    Console.WriteLine("Sorry, {0} was not found.  Please make sure you entered the name correctly.", seekFrn.Name);
                else
                {
                    Console.WriteLine("  Name \t\t  Phone Number \tDOB Month/Day/Year");
                    Display(friend[x]);

                  
                }

                Console.Write("\nEnter a specific friend's name for their phone number and birthday, or type 'quit' to exit:");
                seekFrn.Name = Console.ReadLine();
            }

            Console.WriteLine("\nPress 'Enter' to continue...");
            Console.ReadLine();
        }

        // this get the data from the user.........


        public static void GetData(out string name, out string phone, out int month, out int day, out int year)
        {
            string inString;

            Console.Write("\nPlease enter a friend's FIRST and LAST name: ");
            name = Console.ReadLine();
            Console.Write("Please enter {0}'s PHONE number (i.e. 212-555-2121): ", name);
            phone = Console.ReadLine();
            Console.Write("Please enter {0}'s birth MONTH (i.e.: 2 for February): ", name);
            inString = Console.ReadLine();
            month = Convert.ToInt32(inString);
            Console.Write("Please enter {0}'s birth DAY (i.e.: 12): ", name);
            inString = Console.ReadLine();
            day = Convert.ToInt32(inString);
            Console.Write("Please enter {0}'s birth YEAR (i.e.: 1972): ", name);
            inString = Console.ReadLine();
            year = Convert.ToInt32(inString);
        }

        public static void Display(Friend frn)
        {
            Console.WriteLine("  {0,-15} {1,11} \t      {2,3}/{3,3}/{4,4}", frn.Name, frn.Phone,
                frn.Month.ToString(), frn.Day.ToString(), frn.Year.ToString());
        }
    }

    public class Friend : IComparable
    {
        public Friend()
        {
        }

        public string Name { get; set; }
        public string Phone { get; set; }
        public int Month { get; set; }
        public int Day { get; set; }
        public int Year { get; set; }

        public Friend(string name, string phone, int month, int day, int year)
        {
            Name = name;
            Phone = phone;
            Month = month;
            Day = day;
            Year = year;
        }

        public Friend(string name)
        {
            Name = name;
        }

        int IComparable.CompareTo(Object o)
        {
            Friend temp = (Friend)o;
            return this.Name.CompareTo(temp.Name);
        }
    }
}
