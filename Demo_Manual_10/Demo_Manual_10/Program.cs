using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_Manual_10
{
    public delegate void MyDelegate(int input1, int input2); //Task-2

    class Program
    {
        public static void PerformArithmeticOperation(int num1, int num2, MyDelegate arOperation)
        {
            arOperation?.Invoke(num1, num2);
        }

        static void Main(string[] args)
        {
            ArithematicOperations obj = new ArithematicOperations();

                Console.WriteLine("Enter The two integer number:");
                int num1 = Convert.ToInt32(Console.ReadLine());
                int num2 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter the operation you wish to perform on these two numbers");
                Console.WriteLine("Press 1. For Addition 2. For Substraction 3. For Multiplication 4. For Division 5. For Finding Maximum");
                int choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        MyDelegate addDel = new MyDelegate(obj.Add);  //Task-3
                        //addDel.Invoke(num1, num2);   // Task-4
                        PerformArithmeticOperation(num1, num2, addDel);  //Task-5
                        break;
                    case 2:
                        MyDelegate subDel = new MyDelegate(obj.Subtract);
                        //subDel.Invoke(num1, num2);    
                        PerformArithmeticOperation(num1, num2, subDel);
                        break;
                    case 3:
                        MyDelegate mulDel = new MyDelegate(obj.Multiply);
                        //mulDel.Invoke(num1, num2);    
                        PerformArithmeticOperation(num1, num2, mulDel);
                        break;
                    case 4:
                        MyDelegate divDel = new MyDelegate(obj.Division);
                        //divDel.Invoke(num1, num2);    
                        PerformArithmeticOperation(num1, num2, divDel);
                        break;
                    case 5:
                        MyDelegate maxDel = new MyDelegate(obj.Maximum);
                        //maxDel.Invoke(num1, num2);    
                        PerformArithmeticOperation(num1, num2, maxDel);
                        break;
                    default:
                        Console.WriteLine("Please Enter the valid input");
                        break;
                }
            Console.ReadKey();
        }
    }
}