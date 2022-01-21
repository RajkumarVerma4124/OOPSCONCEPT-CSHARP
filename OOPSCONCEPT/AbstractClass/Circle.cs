using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPSCONCEPT.AbstractClass
{
    public class Circle : Shape
    {
        public void GetRadius()
        {
            Console.Write("Enter The Radius of Circle  :  ");
            radiusOfCircle = float.Parse(Console.ReadLine());
        }
        public override float Area()
        {
            return 3.14F * radiusOfCircle * radiusOfCircle;
        }
        public override float Circumference()
        {
            return 2 * 3.14F * radiusOfCircle;

        }
    }
}
