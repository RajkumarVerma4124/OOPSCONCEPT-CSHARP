using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OOPSCONCEPT.ClassesAndObjects;
using OOPSCONCEPT.Polymorphism.MethodOverloading;
using OOPSCONCEPT.Polymorphism.MethodOveriding;
using OOPSCONCEPT.Inheritence;
using OOPSCONCEPT.PassByValueAndReference;
using OOPSCONCEPT.AbstractClass;
using OOPSCONCEPT.Interface;

namespace OOPSCONCEPT
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("1: Classes and Object " +
                              "\n2: PolyMorphism Method Overloading for calculator" +
                              "\n3: Method Overiding for empwage partime and full time" +
                              "\n4: Inheritence Program for empwage adding address for emp" +
                              "\n5: Pass By Value And Pass By Reference"+
                              "\n6: Abstract Example"+
                              "\n7: Interface Example"+
                              "\n8: Exit"
                              );
                Console.Write("Enter the choice from above : ");
                int choice = int.Parse(Console.ReadLine());
                switch(choice)
                {
                    case 1:
                        Console.WriteLine("");
                        //Classes and Object program
                        EmployeeData employeeData = new EmployeeData();
                        employeeData.EmployeeDataEntry();
                        break;
                    case 2:
                        //Polymorphism Method Overloading
                        Calculator op = new Calculator();
                        Console.WriteLine(op.Add(14.23, 15.20));
                        Console.WriteLine(op.Mul(14.23, 15.20, 13.53));
                        CalculatorData.MathOperation();
                        Console.ReadLine();
                        break;
                    case 3:
                        //Method Overiding Program,
                        Console.WriteLine("1: Part Time or \n2: Full Time");
                        int incChoice = int.Parse(Console.ReadLine());
                        EmployeeWageData employeeWageData = new EmployeeWageData();
                        employeeWageData.EmpWageDataEntry(incChoice);
                        break;
                    case 4:
                        //Employ With Address program using inheritence
                        EmployeeAddressData.EmpAddress();
                        break;
                    case 5:
                        //Pass By Value and Pass By Reference
                        PassByValue.GetNumbers();
                        Console.WriteLine();
                        PassByReference.AddStudentName();
                        Console.WriteLine();
                        break;
                    case 6:
                        AbstractCall.CallDerivedMethod();
                        Console.ReadLine();
                        break;
                    case 7:
                        InterfaceClass.CallDerivedMethod();
                        Console.ReadLine();
                        break;
                    case 8:
                        Environment.Exit(0);
                        return;
                    default:
                        Console.WriteLine("Choose between 1 and 4 choose again");
                        Console.ReadLine();
                        continue;
                }
            }                   
        }
    }
}
