using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROG2070Assignment2
{
    class Program
    {
        static void Main(string[] args)
        {
            string userInput;
            string userSide1;
            string userSide2;
            string userSide3;

            bool validInput = true;
            bool showMenu = false;

            do
            {
                Console.WriteLine("Menu options:");
                Console.WriteLine("1. Enter triangle dimensions");
                Console.WriteLine("2. Exit");
                Console.WriteLine();
                Console.Write("Your Answer: ");
                userInput = Console.ReadLine();

                try
                {
                    int.TryParse(userInput, out int input);
                    if (input == 1)
                    {
                        validInput = true;
                        Console.Write("Enter 1st number: ");
                        userSide1 = Console.ReadLine();
                        Console.Write("Enter 2nd number: ");
                        userSide2 = Console.ReadLine();
                        Console.Write("Enter 3rd number: ");
                        userSide3 = Console.ReadLine();
                        Console.WriteLine();
                       
                        Console.WriteLine(TriangleSolver.Analyze(int.Parse(userSide1), int.Parse(userSide2), int.Parse(userSide3)));
                        Console.WriteLine();
                        showMenu = true;
                    }
                    else if (input == 2)
                    {
                        validInput = true;
                        Environment.Exit(0);
                    }
                    else
                    {
                        Console.WriteLine("Incorrect option, please choose between 1-2");
                        Console.WriteLine();
                        validInput = false;
                    }
                }
                catch (Exception)
                {
                    validInput = false;
                    Console.WriteLine("Incorrect input, please press enter to try again");
                    Console.ReadLine();
                }
            } while (!validInput || showMenu);

            Console.ReadLine();
        }
    
    }
}
