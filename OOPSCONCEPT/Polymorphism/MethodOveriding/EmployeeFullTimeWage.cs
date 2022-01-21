using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OOPSCONCEPT.ClassesAndObjects;
using OOPSCONCEPT.Encapsulation;

namespace OOPSCONCEPT.Polymorphism.MethodOveriding
{
    public class EmployeeFullTimeWage : EmpMixedWage
    {
        //Instance Variable
        private const int FULL_TIME = 1;

        public new int EmployMonthWage(EmployeeWageInitialization empWage)
        {
            //local Variable
            int dailyWage, totalWage = 0, dailyEmpHours, hours = 0, day = 0;
            Random random = new Random();

            //Computation
            while (hours < empWage.GetTotalHours() && day < empWage.GetDaysPerMonth())
            {
                int empCheck = random.Next(1,3);
                switch (empCheck)
                {
                    case FULL_TIME:
                        dailyEmpHours = empWage.GetDailyHours() ;
                        break;
                    default:
                        dailyEmpHours = 0;
                        break;
                }
                hours += dailyEmpHours;
                day++;
                dailyWage = dailyEmpHours * empWage.GetWagePerHours();
                totalWage += dailyWage;
                Console.WriteLine("Day : " + day + "  Hours : " + hours + "  DailyWage : " + dailyWage + "  TotalWage : "
                        + totalWage);
            }
            Console.WriteLine("Employ Name " + empWage.GetName() + " Got Total monthly wage of Rs : " + totalWage + "  and Total Hours : " + hours + "  Total Day is : " + day);
            Console.WriteLine();

            return totalWage;
        }
    }
}
