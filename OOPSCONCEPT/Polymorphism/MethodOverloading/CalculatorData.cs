using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPSCONCEPT.Polymorphism.MethodOverloading
{
    internal class CalculatorData
    {
        public static void MathOperation()
        {
            Console.Write("Enter First Number : ");
            int num1 = int.Parse(Console.ReadLine());
            Console.Write("Enter Second Number : ");
            int num2 = int.Parse(Console.ReadLine());
            Console.Write("Enter Third Number : ");
            int num3 = int.Parse(Console.ReadLine());
            Console.Write("Enter Fourth Number : ");
            int num4 = int.Parse(Console.ReadLine());
            Console.Write("Enter Fifth Number : ");
            int num5 = int.Parse(Console.ReadLine());
            

            Console.WriteLine("1: +\n2: *");
            Console.Write("Enter The choice from above : ");
            int choice = int.Parse(Console.ReadLine());
            Calculator mathOp = new Calculator();
            while(true)
            {
                switch (choice)
                {

                    case 1:
                        Console.WriteLine("Enter How Many Number You Want To Add");
                        int addCount = int.Parse(Console.ReadLine());
                        if (addCount == 2)
                        {
                            Console.WriteLine(mathOp.Add(num1, num2));
                            return;
                        }
                        if (addCount == 3)
                        {
                            Console.WriteLine(mathOp.Add(num1, num2, num3));
                            return;
                        }                         
                        if (addCount == 4)
                        {
                            Console.WriteLine(mathOp.Add(num1, num2, num3, num4));
                            return;
                        }                           
                        if (addCount == 5)
                        {
                            Console.WriteLine(mathOp.Add(num1, num2, num3, num4, num5));
                            return;
                        }
                        if (addCount == 1 || addCount > 5)
                        {
                            Console.WriteLine("Enter The Right Count");
                            continue;
                        }                         
                        break;
                    case 2:
                        Console.WriteLine("Enter How Many Number You Want To Multiply");
                        int mulCount = int.Parse(Console.ReadLine());
                        if (mulCount == 2)
                        {
                            Console.WriteLine(mathOp.Mul(num1, num2));
                            return;
                        }
                        if (mulCount == 3)
                        {
                            Console.WriteLine(mathOp.Mul(num1, num2, num3));
                            return;
                        }
                        if (mulCount == 4)
                        {
                            Console.WriteLine(mathOp.Mul(num1, num2, num3, num4));
                            return;
                        }
                        if (mulCount == 5)
                        {
                            Console.WriteLine(mathOp.Mul(num1, num2, num3, num4, num5));
                            return;
                        }
                        if (mulCount == 1 || mulCount > 5)
                        {
                            Console.WriteLine("Enter The Right Count");
                            continue;
                        }
                        break;
                    case 3:
                        Environment.Exit(0);
                        return;
                    default:
                        Console.WriteLine("Enter the right choice");
                        continue;
                }
            }

        }
    }
}
