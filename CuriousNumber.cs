using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VarahiAssignment
{
    internal class CuriousNumber
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a number :- ");
            string numStr = Console.ReadLine();
            int sum1 = 0;

            foreach (char c in numStr)
            {
                int digit = (int)Char.GetNumericValue(c);
                sum1 += Factorial(digit);
            }

            int num = int.Parse(numStr);

            if (sum1 == num)
            {
                Console.WriteLine("Sum of factorial of " + num + " is " + sum1);
            }
            else
            {
                Console.WriteLine("Sum of factorial of " + num + " is " + sum1);
            }
        }

        static int Factorial(int n)
        {
            if (n == 0)
                return 1;
            return n * Factorial(n - 1);
        }
    }
}
