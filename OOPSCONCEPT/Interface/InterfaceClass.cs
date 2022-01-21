using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPSCONCEPT.Interface
{
    internal class InterfaceClass
    {
        public static void CheckPlace(ICity city)
        {
            city.FavouritePlace();
            city.FavouriteFood();
        }

        public static void CallDerivedMethod()
        {
            Mumbai mum = new Mumbai();
            Delhi del = new Delhi();
            CheckPlace(mum);
            CheckPlace(del);
        }
    }
}
