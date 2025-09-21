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
            // NOTE that the print statement below MUST be outside the while loop,
            // otherwise it will print the message every time the user enters an invalid matriculation number
            // I made this mistake in my first attempt
            Console.WriteLine($"Hello {name}, your matriculation number is {matNumber}.");
        }

        /* Q4. Modify your program to check that your matriculation number is 8 digits long, 
         * if it is > than 8 digits print "Number too long" if it is less than 8 digits print "Number too short".
         * 
         * NOTE: since we will only compare 3 conditions (> 8, < 8, == 8), we can use an if statement,
         * however, if we were to compare many different cases,
         * we could use a switch statement instead.
         * Since I don't know if we will study switch statements later in the module,
         * I will link a page about switch statements here: https://www.w3schools.com/cs/cs_switch.php
         */

        public static void Q4()
        {
            /** This was probably the hardest so far. I solved it with 2 while loops and 2 if statements nested
             * I do believe there is a better way to do this, maybe by checking both at the same time?
             * NOTE: I initialized 2 booleans to check both conditions, I could have just used the while (false)
             * and then return true when the conditions are met, but I think that having a variable that keeps track
             * of the state is clearer when reading back the code.
             * 
             */

            // THE CODE BELOW DOES NOT WORK
            // bool startsWith4 = false;
            // bool has8digits = false;
            // This will keep running until POINT 4 is reached
            //while (!startsWith4)
            //{
            //    // POINT 1: if the matriculation number starts with 4, we enter the first loop
            //    if (matNumber.StartsWith("4"))
            //    {
            //        // POINT 2: now we keep track of whether the matriculation number has 8 digits
            //        while (!has8digits)
            //        {
            //            // POINT 3: WAIT, this doesn't work because now I ignore the check for POINT 1.
            //            if (matNumber.Length < 8)
            //            {
            //                Console.WriteLine("Number too short. Your matriculation number is 8 digits long. Try again below: ");
            //                matNumber = Console.ReadLine();
            //            }
            //            else if (matNumber.Length > 8)
            //            {
            //                Console.WriteLine("Number too long. Your matriculation number is 8 digits long. Try again below: ");
            //                matNumber = Console.ReadLine();
            //            }
            //            else
            //            {
            //                Console.WriteLine($"Your matriculation number is {matNumber}");
            //                has8digits = true;
            //            }
            //        }
            //        startsWith4 = true;
            //    }
            //    else
            //    {
            //        Console.WriteLine("Error: Matriculation number must start with a 4. Please try again below: ");
            //        matNumber = Console.ReadLine();
            //    }
            //}

            Console.WriteLine("Please, enter your matriculation number below: ");
            string matNumber;
            bool isValid = false;

            // In retrospective this is way easier that what I was thinking
            // I made it too complicate by trying to be smart about it
            // I could still use switch cases here, though

            while (!isValid)
            {
                matNumber = Console.ReadLine();

                if (!matNumber.StartsWith("4"))
                {
                    Console.WriteLine("Error: Matriculation number must start with a 4. Please try again below:  ");
                    continue;
                }
                if (matNumber.Length < 8)
                {
                    Console.WriteLine("Number too short. Your matriculation number is 8 digits long. Try again below: ");
                    continue;
                }
                if (matNumber.Length > 8)
                {
                    Console.WriteLine("Number too long. Your matriculation number is 8 digits long. Try again below: ");
                    continue;
                }
                Console.WriteLine($"Your matriculation number is {matNumber}");
                isValid = true;
            }
        }

        public static void Q5()
        {
            // TO DO
        }

        public static void Q6()
        {
            // TO DO
        }
    }
}
