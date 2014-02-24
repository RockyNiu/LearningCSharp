using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpMethodExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Calculator c = new Calculator();
            Console.WriteLine(c.GetConeVolumn(10,100));
        }
    }

    class Calculator
    {
        double pi = Math.PI;
        
        public double GetCircleArea(double r)
        {
            return pi * r * r;

        }

        public double GetCylinderVolumn(double r, double h) 
        {
            return GetCircleArea(r) * h;
        }

        public double GetConeVolumn(double r, double h) 
        {
            return GetCylinderVolumn(r, h) / 3;
        }


    }
}
