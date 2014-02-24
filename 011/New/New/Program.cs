using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace New
{
    class Program
    {
        static void Main(string[] args)
        {
            var person = new { Name = "A", Age = 30 };
            Console.WriteLine(person.Age);
            Console.WriteLine(person.Name);
            Console.WriteLine(person.GetType().Name);

            var student = new { Name = "B", Age = 20, Score = 100 };
            Console.WriteLine(student.GetType().Name);

            uint x = uint.MaxValue;
            Console.WriteLine(x);
            String binStr = Convert.ToString(x, 2);
            Console.WriteLine(binStr);

            try
            {
                uint y = unchecked(x+1);


                Console.WriteLine(y);
                binStr = Convert.ToString(y, 2);
                Console.WriteLine(binStr);
            }
            catch (OverflowException ex)
            {
                Console.WriteLine("error:" + ex.Message);
            }

            Console.WriteLine("int: "+sizeof(int));
            Console.WriteLine("double: "+sizeof(double));
            Console.WriteLine("long" + sizeof(long));
            unsafe 
            {
                Console.WriteLine("Student: " + sizeof(Student));
                Student stu;
                stu.Id = 1;
                stu.Score = 100;
                Student* pStu = &stu;
                pStu->Id = 2;
                pStu->Score = 59;
                Console.WriteLine(stu.Id);
                Console.WriteLine(pStu->Score);
            }

            int max = int.MaxValue;
            int min = int.MinValue;
            Console.WriteLine("max int:" + max);
            Console.WriteLine(Convert.ToString(max, 2).PadLeft(32,'0'));
            Console.WriteLine("min int:" + min);
            Console.WriteLine(Convert.ToString(min,2).PadLeft(32,'0'));
            int _min = checked(-min);
            Console.WriteLine("-min:" + _min);
        }
    }

    struct Student {
        public int Id;
        public long Score;
    }
}
