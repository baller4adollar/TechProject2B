// Programmer: Nikhil Patel
// Proect Name: Tech Assignment 2B
//Purpose: The code is to take an integer input and convert it to a letter grade depending on where it lies in the range.

using System;

namespace TechProject2B
{
    class Program
    {
        static void Main(string[] args)
        {
            // This try feature shows the possible outcomes from integer values entered
            try
            {
                Console.WriteLine("What grade do you expect to get in ISM 4300? Please enter an integer:");
                int grade = int.Parse(Console.ReadLine());
                Console.WriteLine(grade);

                if ((grade >= 0) && (grade <= 150))
                {

                    if (grade >= 90)
                    {
                        Console.WriteLine("Amazing! Your grade letter is an A");
                    }

                    else if ((grade >= 80) && (grade <= 89))
                    {
                        Console.WriteLine("Good Job! Your grade letter is a B");
                    }
                    else if ((grade >= 70) && (grade <=79))
                    {
                        Console.WriteLine("Your grade letter is a C");
                    }
                    else if ((grade >= 60) && (grade <= 69))
                    {
                        Console.WriteLine("Your so close to average! Your grade letter is a D");
                    }
                    else if ((grade >= 0) && (grade <= 59))
                    {
                        Console.WriteLine("Welp there is always next semester! Your grade letter is an F");
                    }
                }
                // Readkey was incorporated to make sure the information entered was correct
                else
                {
                    Console.WriteLine("Please enter a number between 0 and 150");
                    Console.ReadKey(true);
                }
                // Only one number can be inputed at a time, so I created the writeline to inform the users
                Console.WriteLine(" If you would like to enter another number, exit the program and input another number after");
                Console.ReadKey(true);
            }
        catch
            {
                // Error message if something outside the range was inputed in 
                Console.WriteLine("Error! The program is now going to close, please click any key to continue...");
                Console.ReadKey(true);
            }
        }
    }
}
