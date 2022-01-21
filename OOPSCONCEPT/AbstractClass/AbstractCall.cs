using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPSCONCEPT.AbstractClass
{
    public class AbstractCall
    {
        public static void Calculate(Shape S)
        {
            Console.WriteLine("Area : {0}", S.Area());
            Console.WriteLine("Circumference : {0}", S.Circumference());
        }
        public static void CallDerivedMethod()
        {
            Rectangle result = new Rectangle();
            result.GetLenthBreadth();
            Calculate(result);
            Console.WriteLine();
            Console.ReadLine();

            Circle resultCircle = new Circle();
            resultCircle.GetRadius();
            Calculate(resultCircle);
            Console.ReadLine();
        }
    }
}

