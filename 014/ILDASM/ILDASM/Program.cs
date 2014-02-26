using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ILDASM
{
    class Program
    {
        static void Main(string[] args)
        {
            double result = GetCylinderVolumn(10, 100);
            Console.WriteLine(result);
        }

        static double GetCylinderVolumn(double r, double h)
        {
            double area = Math.PI * r * r;
            double volumn = area * h;
            return volumn;
        }

    }
}
