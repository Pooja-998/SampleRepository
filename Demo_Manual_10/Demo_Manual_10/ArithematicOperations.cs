using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_Manual_10
{
        public class ArithematicOperations  //Task-1
        {
            public void Add(int num1, int num2)
            {
                int sum = num1 + num2;
                Console.WriteLine($"Sum of {num1} and {num2} is {sum}");
            }

            public void Subtract(int num1, int num2)
            {
                int minus = num1 - num2;
                Console.WriteLine($"Difference of {num1} and {num2} is {minus}");
            }

            public void Multiply(int num1, int num2)
            {
                int product = num1 * num2;
                Console.WriteLine($"Product of {num1} and {num2} is {product}");
            }

            public void Division(int num1, int num2)
            {
                if (num2 == 0)
                {
                    Console.WriteLine($"Division of {num1} by 0 not possible");
                }
                else
                {
                    double divide = (double)num1 / num2;
                    Console.WriteLine($"Quotient of {num1} and {num2} is {divide}");
                }
            }

            public void Maximum(int num1, int num2)
            {
                if (num1 > num2)
                {
                    Console.WriteLine($"Maximum of {num1} and {num2} is {num1}");
                }
                else
                {
                    Console.WriteLine($"Maximum of {num1} and {num2} is {num2}");
                }
            }
        }
    }

