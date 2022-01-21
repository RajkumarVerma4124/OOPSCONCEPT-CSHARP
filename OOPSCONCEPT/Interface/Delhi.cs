using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPSCONCEPT.Interface
{
     internal class Delhi : ICity
    {
        public void FavouriteFood()
        {
            Console.WriteLine("Delhi,s Popular Food is Chole Kulche");
            Console.ReadLine();
        }

        public void FavouritePlace()
        {
            Console.WriteLine("Delhi,s Popular Place Is India Gate");
            Console.ReadLine();
        }
    }
}
