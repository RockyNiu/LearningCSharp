using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructor
{
    class Program
    {
        static void Main(string[] args)
        {
            Student stu = new Student(1, "Hello World");

        }
    }

    class Student
    {
        public Student(int initId, string initName)
        {
            this.ID = initId;
            this.Name = initName;
        }

        public Student()
        {
            this.ID = 0;
            this.Name = "No name";
        }

        public int ID;
        public string Name;
    }
}
