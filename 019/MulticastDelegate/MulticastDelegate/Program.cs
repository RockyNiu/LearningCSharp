﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace MulticastDelegate
{
    class Program
    {
        static void Main(string[] args)
        {
            Student stu1 = new Student() {ID = 1, PenColor = ConsoleColor.Yellow };
            Student stu2 = new Student() { ID = 2, PenColor = ConsoleColor.Green };
            Student stu3 = new Student() { ID = 3, PenColor = ConsoleColor.Red };

            Action action1 = new Action(stu1.DoHomework);
            Action action2 = new Action(stu2.DoHomework);
            Action action3 = new Action(stu3.DoHomework);

            //action1.BeginInvoke(null,null);
            //action2.BeginInvoke(null, null);
            //action3.BeginInvoke(null,null);

            //Thread thread1 = new Thread(new ThreadStart(stu1.DoHomework));
            //Thread thread2 = new Thread(new ThreadStart(stu2.DoHomework));
            //Thread thread3 = new Thread(new ThreadStart(stu3.DoHomework));

            //thread1.Start();
            //thread2.Start();
            //thread3.Start();

            Task task1 = new Task(stu1.DoHomework);
            Task task2 = new Task(new Action(stu2.DoHomework));
            Task task3 = new Task(new Action(stu3.DoHomework));

            task1.Start();
            task2.Start();
            task3.Start();

            for (int i = 0; i < 5; i++)
            {
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.WriteLine("Main thread {0}", i);
                Thread.Sleep(1000);
            }
        }
    }
    class Student
    {
        public int ID { get; set; }
        public ConsoleColor PenColor { get; set; }

        public void DoHomework()
        {
            for (int i = 0; i < 5; i++)
            {
                Console.ForegroundColor = this.PenColor;
                Console.WriteLine("Student {0} doing homework {1} hour(s).", this.ID, i);
                Thread.Sleep(1000);
            }
           
        }
    }
}
