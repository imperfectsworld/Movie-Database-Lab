using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Movie_Database_Lab
{
    internal class Valid
    {

        public static int GetInputBetween1and4()
        {
            int result = -1;
            while (int.TryParse(Console.ReadLine(), out result) == false || result <= 0 || result >= 5)
            {
                Console.WriteLine("Invalid input. Try again with a number between 1 and 4");
            }
            return result;
        }


        public static bool GetContinue()
        {
            bool result = false;
            while (true)
            {
                Console.WriteLine("Would you like to run again? y/n");
                string choice = Console.ReadLine().Trim().ToLower();
                if (choice == "y")
                {
                    result = true;
                    break;
                }
                else if (choice == "n")
                {
                    result = false;
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid input. Try again");
                }
            }
            return result;
        }




    }
}
