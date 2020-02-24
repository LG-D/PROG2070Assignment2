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

            do
            {
                Console.Clear();
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

                        int.TryParse(userSide1, out int side1);
                        int.TryParse(userSide2, out int side2);
                        int.TryParse(userSide3, out int side3);

                        Console.WriteLine(TriangleSolver.Analyze(side1, side2, side3));
                    }
                    else if (input == 2)
                    {
                        validInput = true;
                        Environment.Exit(0);
                    }
                    else
                    {
                        validInput = false;
                    }
                }
                catch (Exception)
                {
                    Console.WriteLine("Incorrect input, please try again");
                    validInput = false;
                }
            } while (!validInput);

            Console.ReadLine();
        }
    
    }
}
