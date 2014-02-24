using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PropertySample
{
    class Program
    {
        static void Main(string[] args)
        {
            AdventureWorks2012Entities proxy = new AdventureWorks2012Entities();
            foreach (Product p in proxy.Products)
            {
                Console.WriteLine(p.Name);
            }
            Console.WriteLine("++++++++++++++++/n"+proxy.Products.Count());
        }
    }
}
