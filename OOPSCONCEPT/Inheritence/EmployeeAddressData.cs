using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OOPSCONCEPT.Encapsulation;
using OOPSCONCEPT.Polymorphism.MethodOveriding;

namespace OOPSCONCEPT.Inheritence
{
    public class EmployeeAddressData
    {
        public static void EmpAddress()
        {
            //Employee Address
            Console.Write("Enter The StreetNum Of The Employee : ");
            int streetNum = int.Parse(Console.ReadLine());
            Console.Write("Enter The City Of The  Employee : ");
            string city = Console.ReadLine();
            Console.Write("Enter The State Of The  Employee : ");
            string state = Console.ReadLine();
            Console.Write("Enter The Country Of The  Employee : ");
            string country = Console.ReadLine();

            //Employee Company Details
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

            //Creating the object for monthly wage including both part time and full time 
            EmpMixedWage empWage = new EmpMixedWage();

            //Creating employee company details Object
            EmployeeWageInitialization empCompany = new EmployeeWageInitialization(company,  name,  wagePerHours,  dailyHours,  dayPerMonth,  totalHours);
           
            ///Creating employee address details Object
            EmployeeAddress empOne = new EmployeeAddress(streetNum, city, state, country);

            //displaying the employeedetails           
            Console.WriteLine("Employ Name : " + empOne.GetName() +
                                "\nGot Total monthly Wage Of Rs : " + empWage.EmployMonthWage(empCompany) +
                                "\nFrom Company Name : " + empOne.GetCompanyName() +
                                "\nEmployee " + empOne.GetName() + " Street Number : " + empOne.streetNum +
                                "\nEmployee " + empOne.GetName() + " City : " + empOne.city +
                                "\nEmployee " + empOne.GetName() + " Country : " + empOne.country
                                );

           
            Console.ReadLine();
        }
    }
}
