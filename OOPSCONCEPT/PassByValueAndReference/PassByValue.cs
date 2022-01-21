using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPSCONCEPT.PassByValueAndReference
{
    public class PassByValue
    {
        public static void ChangeValue(int x)
        {
            x = 200;

            Console.WriteLine(x);
        }

        public static void GetNumbers()
        {
            int i = 100;

            Console.WriteLine(i);

            ChangeValue(i);

            Console.WriteLine(i);
        }
    }
}
