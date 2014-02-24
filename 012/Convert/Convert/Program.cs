using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConvertExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Student stu = new Student();
            Human h = stu;

            ushort u = ushort.MaxValue;
            Console.WriteLine(u);
            Console.WriteLine(Convert.ToString(u,2).PadLeft(32,'0'));
            uint x = 65536;
            ushort y = (ushort)x;
            Console.WriteLine(Convert.ToString(x,2).PadLeft(32,'0'));
            Console.WriteLine(y);
        }
    }

    class Student : Human
    {
        public void Study()
        {
            Console.WriteLine("Studying");
        }
    }
    class Human
    {
        public void Live()
        {
            Console.WriteLine("Living");
        }
    }
}
