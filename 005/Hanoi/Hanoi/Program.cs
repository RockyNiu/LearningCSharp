using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hanoi
{
    class Program
    {
        static void Main(string[] args)
        {
            Hanoi h = new Hanoi();
            Stopwatch st = new Stopwatch();
            st.Start();
            ulong steps = h.CountSteps(64);
            st.Stop();
            Console.WriteLine(st.Elapsed.ToString());
            Console.WriteLine(steps);
        }
    }

    class Hanoi
    {
        public ulong CountSteps(int n)
        {
            if (n == 1)
            {
                return 1;
            }
            else {
                return 1 + CountSteps(n - 1) * 2;
            }
        }
    }
}
