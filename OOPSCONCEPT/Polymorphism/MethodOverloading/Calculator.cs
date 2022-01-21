using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPSCONCEPT.Polymorphism.MethodOverloading
{
    public class Calculator
    {
        //Adding Integer numbers upto 5
        public int Add(int i, int j)
        {
            return i + j;
        }
        public int Add(int i, int j, int k)
        {
            return i + j + k;
        }
        public int Add(int i, int j,int k, int l)
        {
            return i + j + k + l;
        }
        public int Add(int i, int j, int k, int l, int m)
        {
            return i + j + k + l + m;
        }
        public int Add(int i, int j, int k, int l, int m, int n)
        {
            return i + j + k + l + m + n;
        }


        //Adding double numbers upto 5
        public double Add(double i, double j)
        {
            return Math.Round(i + j, 2);
        }
        public double Add(double i, double j, double k)
        {
            return Math.Round(i + j + k, 2);
        }
        public double Add(double i, double j, double k, double l)
        {
            return Math.Round(i + j + k + l, 2);
        }
        public double Add(double i, double j, double k, double l, double m)
        {
            return Math.Round(i + j + k + l + m, 2);
        }
        public double Add(double i, double j, double k, double l, double m, double n)
        {
            return Math.Round(i + j + k + l + m + n, 2);
        }

        
        //Multiply Integer Number upto 5
        public int Mul(int i, int j)
        {
            return i * j;
        }
        public int Mul(int i, int j, int k)
        {
            return i * j * k;
        }
        public int Mul(int i, int j, int k, int l)
        {
            return i * j * k * l;
        }
        public int Mul(int i, int j, int k, int l, int m)
        {
            return i * j * k * l * m;
        }
        public int Mul(int i, int j, int k, int l, int m, int n)
        {
            return i * j * k * l * m * n;
        }


        //Multiply double numbers
        public double Mul(double i, double j)
        {
            return Math.Round(i * j, 2);
        }
        public double Mul(double i, double j, double k)
        {
            return Math.Round(i * j * k, 2); 
        }
        public double Mul(double i, double j, double k, double l)
        {
            return Math.Round(i * j * k * l, 2);
        }
        public double Mul(double i, double j, double k, double l, double m)
        {
            return Math.Round(i * j * k * l * m, 2);
        }
        public double Mul(double i, double j, double k, double l, double m, double n)
        {
            return Math.Round(i * j * k * l * m * n, 2);
        }



    }
}
