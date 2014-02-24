using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConsoleTest
{
    class Program
    {
        static unsafe void Main(string[] args)
        {
            //int x = 100;
            //if (x == 200)
            //{
            //    Console.WriteLine("Hello, World!");
            //}


            //dynamic myVar = 100;
            //Console.WriteLine(myVar);
            //myVar = "Hello, World!";
            //Console.WriteLine(myVar);

            //Type myType = typeof(Form);
            //PropertyInfo[] pInfos = myType.GetProperties();
            //MethodInfo[] mInfos = myType.GetMethods();
            //Console.WriteLine(myType.BaseType.BaseType.FullName);
            //foreach (var m in mInfos)
            //{
            //    Console.WriteLine(m.Name);
            //}

            //BadGuy bg = new BadGuy();
            //bg.BadMethod();

            int* p = stackalloc int[9999999];
        }

    }

    //class BadGuy
    //{

    //    public void BadMethod()
    //    {
    //        int x = 100;
    //        this.BadMethod();
    //    }
    //}
}
