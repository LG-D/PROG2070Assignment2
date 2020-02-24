using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROG2070Assignment2
{
    public static class TriangleSolver
    {
        public static string Analyze(int a, int b, int c)
        {
            bool formsTriangle = false;

            StringBuilder output = new StringBuilder();

            if ((a + b > c) && (a + c > b) && (b + c > a))
            {
                formsTriangle = true;
                output.AppendLine("The triangle can be formed");
            }
            else
            {
                formsTriangle = false;
                output.AppendLine("The triangle cannot be formed ");
            }

            if (formsTriangle)
            {
                if (a == b && b == c)
                {
                    output.AppendLine("The triangle is Equilateral");
                }
                else if (a == b || a == c || b == c)
                {
                    output.AppendLine("The triangle is Isosceles");
                }
                else
                {
                    output.AppendLine("The triangle is Scalene");
                }
            }
            return output.ToString();
        }
    }
}
