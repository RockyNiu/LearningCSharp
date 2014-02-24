using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Person
{
    class Program
    {
        static void Main(string[] args)
        {
            //Person p1 = new Person();
            //Person p2 = new Person();
            //p1.Name = "Dear";
            //p2.Name = "Dear's wife";
            //List<Person> nation = p1 + p2;
            //foreach (var p in nation)
            //{
            //    Console.WriteLine(p.Name);
            //}

            //int x = 100;
            //int y = 200;
            //int z = 300;
            //x += y += z;
            //Console.WriteLine(x);
            //Console.WriteLine(y);
            //Console.WriteLine(z);

            //System.IO.File.Create("D:\\Hellow World.txt");

            //Form myForm = new Form();
            //myForm.Text = "Hello, World!";
            //myForm.ShowDialog();

            Person person = new Person("Hello World");
            Action myAction = new Action(person.PrintName);
            myAction();

            //int[] myIntArray = new int[]{1,2,3,4,5};
            //Console.WriteLine(myIntArray[0]);
            //Console.WriteLine(myIntArray[myIntArray.Length-1]);

            //Dictionary<string, Student> stuDic = new Dictionary<string, Student>();
            //for (int i = 0; i < 100; i++)
            //{
            //    Student stu = new Student();
            //    stu.Name = "stu_" + i.ToString();
            //    stu.Score = i;
            //    stuDic.Add(stu.Name, stu);
            //}

            //Student number6 = stuDic["stu_6"];
            //Console.WriteLine(number6.Score);

            //int x = 100;
            //int y = x++;
            //int z = ++x;
            //Console.WriteLine(x);
            //Console.WriteLine(y);
            //Console.WriteLine(z);

            //Type t = typeof(int);
            //Console.WriteLine(t.Namespace);
            //Console.WriteLine(t.FullName);
            //Console.WriteLine(t.Name);
            //int c = t.GetMethods().Length;
            //foreach (var m in t.GetMethods())
            //{
            //    Console.WriteLine(m.Name);
            //}
            //Console.WriteLine(c);

            //double x = default(double);
            //Console.WriteLine(x);

            //int y = default(int);
            //Console.WriteLine(y);

            //Form myForm = default(Form);
            //Console.WriteLine(myForm == null);

            Level level = default(Level);
            Console.WriteLine(level);
        }
    }

    enum Level
    {
        M = 0,
        Low = 0,
        Mid = -1,
        High = 0
    }

    class Person
    {
        public string Name;

        public Person()
        {
            ;
        }

        public Person(string name)
        {
            this.Name = name;
        }

        //public static List<Person> GetMarried(Person p1, Person p2)
        public static List<Person> operator +(Person p1, Person p2)
        {
            List<Person> people = new List<Person>();
            people.Add(p1);
            people.Add(p2);
            for (int i = 0; i < 11; i++)
            {
                Person child = new Person();
                child.Name = p1.Name + "&" + p2.Name + "'s child";
                people.Add(child);
            }

            return people;
        }

        public void PrintName()
        {
            Console.WriteLine(this.Name);
        }
    }

    class Student
    {
        public string Name;
        public int Score;
    }
}
