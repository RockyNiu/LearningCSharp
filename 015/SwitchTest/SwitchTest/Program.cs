using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwitchTest
{
    class Program
    {
        static void Main(string[] args)
        {
            level l = level.Low;
            switch (l)
            {
                case level.Low:
                    break;
                case level.Medium:
                    break;
                case level.High:
                    break;
                default:
                    break;
            }
            Calculator c = new Calculator();
            int result = 0;
            try
            {
                result = c.Add(null, "200");
            }
            catch (ArgumentNullException oe)
            {
                Console.WriteLine(oe.Message);
                //throw;
            }
            Console.WriteLine(result);
        }

        
    }

    class Calculator
    {
        public int Add(string s1, string s2) 
        {
            int a = 0;
            int b = 0;
            Boolean hasError = false;
            try
            {
                a = int.Parse(s1);
                b = int.Parse(s2);
            }
            catch (ArgumentNullException ane)
            {
                //Console.WriteLine("input null!");
                //Console.WriteLine(ane.Message);
                //hasError = true;
                throw;
            }
            catch (FormatException fe)
            {
                Console.WriteLine("input non-number characters!");
                Console.WriteLine(fe.Message);
                hasError = true;

            }
            catch (OverflowException oe)
            {
                Console.WriteLine("input out of range!");
                Console.WriteLine(oe.Message);
                hasError = true;
            }
            finally
            {
                if (hasError)
                {
                    Console.WriteLine("Excecution has error!");
                }
                else
                {
                    Console.WriteLine("enjoy!");
                }
            }
            int result = a + b;
            return result;
        }
    }
}

enum level
{
    Low,
    Medium,
    High
}