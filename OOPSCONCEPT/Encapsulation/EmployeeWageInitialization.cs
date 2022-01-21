using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPSCONCEPT.Encapsulation
{
    public class EmployeeWageInitialization
    {
        //Instance Variable
        private readonly string company;
        private readonly string name;
        private readonly int wagePerHours;
        private readonly int dailyHours;
        private readonly int dayPerMonth;
        private readonly int totalHours;

        public EmployeeWageInitialization()
        {

        }
        public EmployeeWageInitialization(string company, string name, int wagePerHours, int dailyHours, int dayPerMonth, int totalHours)
        {
            this.company = company;
            this.name = name;
            this.wagePerHours = wagePerHours;
            this.dailyHours = dailyHours;
            this.dayPerMonth = dayPerMonth;
            this.totalHours = totalHours;
        }

        //Getting the company name 
        public string GetCompanyName()
        {
            return company;
        }

        //Getting the Employ name
        public string GetName()
        {
            return name;
        }

        //Getting the wageperhout
        public int GetWagePerHours()
        {
            return wagePerHours;
        }

        //Getting the daily hour
        public int GetDailyHours()
        {
            return dailyHours;
        }
        

        //Getting the days per month
        public int GetDaysPerMonth()
        {
            return dayPerMonth;
        }

        //Getting the total hours
        public int GetTotalHours()
        {
            return totalHours;
        }
    }
}
