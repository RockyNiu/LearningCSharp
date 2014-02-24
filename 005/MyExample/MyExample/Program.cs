using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Calculator c = new Calculator();
            Console.WriteLine(c.SumFrom1ToX(3));
        }
    }

    class Calculator
    {
        //public int SumFrom1ToX(int x)
        //{
        //    int result = 0;
        //    for (int i = 1; i < x + 1; i++)
        //    {
        //        result = result + i;
        //    }
        //    return result;
        //}

        public int SumFrom1ToX(int x)
        {
            if (x == 1)
            {
                return 1;
            }
            else
            {
                return x + SumFrom1ToX(x - 1);
            }
        }
    }
}
