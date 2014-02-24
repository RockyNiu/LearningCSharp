using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoneMonkey
{
    class Program
    {
        static void Main(string[] args)
        {
            Stone stone = new Stone();
            stone.Age = 5000;
            Monkey monkey = stone;
            Console.WriteLine(monkey.Age);

            String s1 = "abc";
            String s2 = "ab";
            String s3 = "abcd";
            Console.WriteLine(String.Compare(s1, s2));
            Console.WriteLine(String.Compare(s1, s3));
            Console.WriteLine(String.Compare(s2, s3));

            LittleMonkey m = new LittleMonkey();
            Console.WriteLine(m is Monkey);
            Console.WriteLine(m is Stone);
            Console.WriteLine(m is LittleMonkey);
            Console.WriteLine(m is Object);
            Console.WriteLine(m is object);

            Object o = new Stone();
            Console.WriteLine(o.GetType().Name);
            if (o is Stone)
            {
                Stone s = (Stone)o;
                Console.WriteLine(s.GetType().Name);
                s.move();
            }

            Monkey monkeyKing = o as Monkey;
            Console.WriteLine(monkeyKing==null);

            int? x = 1;
            Console.WriteLine(x);
            x = null;
            Console.WriteLine(x.HasValue);
            int y = x ?? 0;
            Console.WriteLine(x);
            Console.WriteLine(y);
            x = -1;
            y = x ?? 100;
            Console.WriteLine(y);

        }
    }

    class LittleMonkey : Monkey { }

    class Monkey
    {
        public int Age;
        public static implicit operator Monkey(Stone stone)
        {
            Monkey monkey = new Monkey();
            monkey.Age = stone.Age / 1000;
            return monkey;
        }
    }

    class Stone
    {
        public int Age;
        public void move()
        {
            Console.WriteLine("Bang!");
        }
    }
}
