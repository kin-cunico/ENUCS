using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENUCS.Week2
{
    class Week2
    {

        /* Q1. Allow the user to enter a number and then display a message to tell the user whether the number is odd or even.
         * 
         */
        public static void Q1()
        {
            Console.WriteLine("Choose a number: ");
            // We need to convert the string input to an integer. 
            // if we used the method Read() instead of ReadLine(), we would get the ASCII value of the first char.
            // for now I will not check whether the user has entered a valid int or not, we will study error checks later in the module
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

        /* Q2. Write a program that will ask for your name and matriculation number, 
         * then print the message "Hello <name> your matriculation number is <number>" (substitute the name and number that you entered).
         */

        // private string name; ** 1. NOTE METHOD BELOW
        // private int matNumber; ** 1. NOTE METHOD BELOW
        public static void Q2()
        {
            Console.WriteLine("Please enter your name below: ");
            // NOTE 1: If we declare the variables name and matNumber here, they will be local to this method only.
            // Here we can start thinking about where we want to initialize variables
            // for now we will do it just before we need them
            // but later I will start to initialize them at the start of the class
            string name = Console.ReadLine();

            Console.WriteLine("Please enter your matriculation number below: ");
            int matNumber = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"Hello {name}, your matriculation number is {matNumber}.");
        }

        /* Q3. Modify program 2 and check whether the matriculation number starts with a 4, if it does not print an error message.
         * For this I will refactor the code above to meet the requirements for Q3
         */

        public static void Q3()

        {
            Console.WriteLine("Please enter your name below: ");
            // NOTE 1: If we declare the variables name and matNumber here, they will be local to this method only.
            // Here we can start thinking about where we want to initialize variables
            // for now we will do it just before we need them
            // but later I will start to initialize them at the start of the class
            string name = Console.ReadLine();

            bool validMatNumber = false;
            // notice now that I am declaring matNumber as a string to avoid converting it to int and then back to string
            // I am also initializing it to an empty string before the loop so that it is in scope after the loop
            string matNumber = "";

            // the while loop will keep asking for the matriculation number until it starts with 4
            // therefore now we are using some input validation

            // HERE I START TO WONDER WHETER IN C# I CAN DESIGN CLASSES LIKE IN JAVA WHERE I CAN HAVE A CLASS FOR STUDENT
            // AND THE CLASS CAN HAVE METHODS TO SET THE NAME AND MATRICULATION NUMBER, so setters and getters
            while (!validMatNumber)
            {
                Console.WriteLine("Please enter your matriculation number below: ");
                matNumber = Console.ReadLine();
                if (matNumber.StartsWith("4"))
                {
                    validMatNumber = true;
                }
                else
                {
                    Console.WriteLine("Error: Matriculation number must start with a 4. Please try again. ");
                }
            }
            Console.WriteLine($"Hello {name}, your matriculation number is {matNumber}.");
        }

        public static void Q4()
        {
            // TO DO
        }
    }
}
