using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENUCS.Week2
{
    class Week2
    {
        public static void Q1()
        {
            Console.WriteLine("Choose a number between 1 and 1000000: ");
            int number = Convert.ToInt32(Console.ReadLine());
            if (number % 2 == 0)
            {
                Console.WriteLine($"The number {number} is even.");
            }
            else
            {
                Console.WriteLine($"The number {number} is odd.");
            }
        }

        public static void Q2()
        {

        }
    }
}
