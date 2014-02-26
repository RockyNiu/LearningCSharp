using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Form myForm = new Form();
            myForm.Text = "Hello World!";
            myForm.Load += myForm_Load;
            myForm.ShowDialog();
        }

        static void myForm_Load(object sender, EventArgs e)
        {
            Form form = sender as Form;
            if (form == null) 
            {
                return;
            }
            form.Text = "Hello, New world!";
        }
    }
}
