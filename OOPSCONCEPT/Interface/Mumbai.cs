using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPSCONCEPT.Interface
{
    internal class Mumbai: ICity
    {
        public void FavouriteFood()
        {
            Console.WriteLine("Mumbai,s Popular Breakfast Food IS VadaPav");
            Console.ReadLine();
        }

        public void FavouritePlace()
        {
            Console.WriteLine("Mumbai,s Popular Place Is Marine Drive");
            Console.ReadLine();
        }
    }
}
