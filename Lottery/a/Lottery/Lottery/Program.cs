using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// CHAPTER 4 EXERCISE 9a
// Wilman Gonzales 

namespace Lottery
{
    class Program
    {
        static void Main(string[] args)
        {
            // declaring the variables that will be used 

            int iNum1;
            int iNum2;
            int iNum3;
            int iCount;
            int iGuess;

            // declaring the constants of the application

            const int iBALLS = 3;
            const int iMATCHONE = 10;
            const int iMATCHTWO = 100;
            const int iMATCHTHREE = 1000;
            const int iMATCHFOUR = 10000;


            // declaring arrays needed

            int[] iSortedNums = new int[3];
            int[] iGuesses = new int[3];
            int[] iSortedGuesses = new int[3];

            // generating random numbers

            Random randomnumber = new Random();
            // allow numbers only between 1 and 4

            iNum1 = randomnumber.Next(1, 5); 
            iNum2 = randomnumber.Next(1, 5);
            iNum3 = randomnumber.Next(1, 5);
            iSortedNums[0] = iNum1;
            iSortedNums[1] = iNum2;
            iSortedNums[2] = iNum3;
            Array.Sort(iSortedNums); // sort 

            for (iCount = 0; iCount < iBALLS; iCount++)
            {
                Console.Write("\nNo:" + (iCount + 1) + " Choose your number,between 1 and 4: ");
                iGuess = Convert.ToInt32(Console.ReadLine());

                while (iGuess < 1 || iGuess > 4)
                {
                    Console.WriteLine("You have entered an incorrect number please try again");
                    Console.Write("\nNo:" + (iCount + 1) + " Choose your number, between 1 and 4: ");
                    iGuess = Convert.ToInt32(Console.ReadLine());
                }

                iGuesses[iCount] = iGuess;
                iSortedGuesses[iCount] = iGuess;
            }

            Array.Sort(iSortedGuesses); // sort            

            Console.WriteLine();
            Console.WriteLine("The random numbers are    : " + iNum1 + ", " + iNum2 + ", " + iNum3);
            Console.WriteLine("The numbers you chose are : " + iGuesses[0] + ", " + iGuesses[1] + ", " + iGuesses[2]);
            Console.WriteLine();

            if (iGuesses[0] == iNum1 && iGuesses[1] == iNum2 && iGuesses[2] == iNum3)
            {
                Console.WriteLine("you won $" + iMATCHFOUR);
            }

            else if (iSortedGuesses[0] == iSortedNums[0] && iSortedGuesses[1] == iSortedNums[1]
            && iSortedGuesses[2] == iSortedNums[2])
            {
                Console.WriteLine("you won $" + iMATCHTHREE);
            }

            else if ((iGuesses[0] == iNum1 && iGuesses[1] == iNum2) || (iGuesses[1] == iNum2 &&

            iGuesses[2] == iNum3))
            {
                Console.WriteLine("you won $" + iMATCHTWO);
            }

            else if (iGuesses[0] == iNum1 || iGuesses[1] == iNum2 || iGuesses[2] == iNum3)
            {
                Console.WriteLine("you won $" + iMATCHONE);
            }

            else
            {
                Console.WriteLine("Sorry, it seems that you didn't win anything. Please try your luck again!!");
            }

            Console.ReadKey();
        }
    }
}
