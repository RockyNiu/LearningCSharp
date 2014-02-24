using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClassAndInstance
{
    class Program
    {
        static void Main(string[] args)
        {
            Form form1 = new Form();
            form1.ShowDialog();
            Form form2 = form1;
            form2.Text = "Hello, World!";
            form2.ShowDialog();
        }
    }
}
