using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OOPSCONCEPT.Encapsulation;

namespace OOPSCONCEPT.Polymorphism.MethodOveriding
{
    internal class EmployeeWageData
    {
        public void EmpWageDataEntry(int incChoice)
        {
            Console.Write("Enter The Name Of The Company : ");
            string company = Console.ReadLine();
            Console.Write("Enter The Name Of The  Employ : ");
            string name = Console.ReadLine();
            Console.Write("Enter The Total Daily Hour : ");
            int dailyHours = int.Parse(Console.ReadLine());
            Console.Write("Enter The Wage Per Hour : ");
            int wagePerHours = int.Parse(Console.ReadLine());
            Console.Write("Enter The Days in a Month : ");
            int dayPerMonth = int.Parse(Console.ReadLine());
            Console.Write("Enter The Total Hours Of That Month You Are Gonna Work : ");
            int totalHours = int.Parse(Console.ReadLine());

            EmployeeWageInitialization empWage = new EmployeeWageInitialization(company, name, wagePerHours, dailyHours, dayPerMonth, totalHours);

            EmployeePartTimeWage partTime = new EmployeePartTimeWage();
            EmployeeFullTimeWage fullTime = new EmployeeFullTimeWage();
            if (incChoice == 1)
                Console.WriteLine("Employ Name " + name + " Got Total monthly Wage Of Rs : " + partTime.EmployMonthWage(empWage) + " From Company Name " + company);
            else
                Console.WriteLine("Employ Name " + name + " Got Total monthly Wage Of Rs : " + fullTime.EmployMonthWage(empWage) + " From Company Name " + company);
            
            Console.WriteLine();
            Console.ReadLine();
        }
    }
}
