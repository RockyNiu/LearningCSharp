

using System;
using Tools;
namespace ConsoleHelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            double result = Calculator.Div(1, 0);
            Console.WriteLine(result);
        }
    }
}
