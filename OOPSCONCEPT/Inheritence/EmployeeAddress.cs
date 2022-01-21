using OOPSCONCEPT.ClassesAndObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OOPSCONCEPT.Encapsulation;

namespace OOPSCONCEPT.Inheritence
{
    //Aggregation 
    public class EmployeeAddress : EmployeeWageInitialization
    {
        public int streetNum;
        public string city;
        public string state;
        public string country;

        public EmployeeAddress(int street, string city, string state, string country)
        {
            this.streetNum = street;
            this.city = city;
            this.state = state;
            this.country = country;
        }


    }
}
