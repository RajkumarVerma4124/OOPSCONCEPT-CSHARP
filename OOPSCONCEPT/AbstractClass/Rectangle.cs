using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPSCONCEPT.AbstractClass
{
    public class Rectangle : Shape
    {
        public void GetLenthBreadth()
        {
            Console.Write("Enter The Length Of Rectangle : ");
            length = float.Parse(Console.ReadLine());

            Console.Write("Enter The Breadth Of Rectangle : ");
            breadth = float.Parse(Console.ReadLine());
        }

        //Override abstract method in the derived class.
        public override float Area()
        {
            return length * breadth;
        }

        public override float Circumference()
        {
            return 2 * (length + breadth);
        }

    }

}