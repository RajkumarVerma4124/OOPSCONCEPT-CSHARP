using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OOPSCONCEPT.Encapsulation;
using OOPSCONCEPT.Polymorphism.MethodOveriding;

namespace OOPSCONCEPT.ClassesAndObjects
{
    internal class EmployeeData
    {
        public void EmployeeDataEntry()
        {
            Console.WriteLine("Calculating The Monthly Employ wage for multiple companies");
            Console.WriteLine();

            Console.Write("Enter The No. Of Records You Want To Enter Max is 4 : ");
            int records = int.Parse(Console.ReadLine());

            if (records <= 4)
            {
                for (int i = 1; i <= records; i++)
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
                    if (i == 1)
                    {
                        EmpMixedWage empOne = new EmpMixedWage();
                        EmployeeWageInitialization companyOne = new EmployeeWageInitialization(company, name, wagePerHours, dailyHours, dayPerMonth, totalHours);
                        Console.WriteLine("Employ Name " + companyOne.GetName() + " Got Total monthly Wage Of Rs : " + empOne.EmployMonthWage(companyOne) + " From Company Name " + companyOne.GetCompanyName());
                        Console.ReadLine();

                    }
                    if (i == 2)
                    {
                        EmpMixedWage empTwo = new EmpMixedWage();
                        EmployeeWageInitialization companyTwo = new EmployeeWageInitialization(company, name, wagePerHours, dailyHours, dayPerMonth, totalHours);
                        Console.WriteLine("Employ Name " + companyTwo.GetName() + " Got Total monthly Wage Of Rs : " + empTwo.EmployMonthWage(companyTwo) + " From Company Name " + companyTwo.GetCompanyName());
                        Console.ReadLine();

                    }
                    if (i == 3)
                    {
                        EmpMixedWage empThree = new EmpMixedWage();
                        EmployeeWageInitialization companyThree = new EmployeeWageInitialization(company, name, wagePerHours, dailyHours, dayPerMonth, totalHours);
                        Console.WriteLine("Employ Name " + companyThree.GetName() + " Got Total monthly Wage Of Rs : " + empThree.EmployMonthWage(companyThree) + " From Company Name " + companyThree.GetCompanyName());
                        Console.ReadLine();

                    }
                    if (i == 4)
                    {
                        EmpMixedWage empFour = new EmpMixedWage();
                        EmployeeWageInitialization companyFour = new EmployeeWageInitialization(company, name, wagePerHours, dailyHours, dayPerMonth, totalHours);
                        Console.WriteLine("Employ Name " + companyFour.GetName() + " Got Total monthly Wage Of Rs : " + empFour.EmployMonthWage(companyFour) + " From Company Name " + companyFour.GetCompanyName());
                        Console.ReadLine();

                    }
                }
            }
            else 
            {
                Console.WriteLine("Entries Should be Less than or equal to 4 ");
                Console.ReadLine();
            }
        }
    }
}

