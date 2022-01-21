using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPSCONCEPT.AbstractClass
{
    public abstract class Shape
    {
        protected float radiusOfCircle, length, breadth;

        //abstract Method
        public abstract float Area();
        public abstract float Circumference();

    }
}