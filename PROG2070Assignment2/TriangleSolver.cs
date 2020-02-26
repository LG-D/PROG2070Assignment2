using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROG2070Assignment2
{
    public static class TriangleSolver
    {
        public static string Analyze(int sideA, int sideB, int sideC)
        {
            string output;

            if ((sideA + sideB > sideC) && (sideA + sideC > sideB) && (sideB + sideC > sideA))
            {
                output = "The triangle can be formed\n";
                if (sideA == sideB && sideB == sideC)
                {
                    output += "The triangle is Equilateral";
                }
                else if (sideA == sideB || sideA == sideC || sideB == sideC)
                {
                    output += "The triangle is Isosceles";
                }
                else
                {
                    output += "The triangle is Scalene";
                }
            }
            else
            {
                output = "The triangle cannot be formed";
            }
            return output;
        }
    }
}
