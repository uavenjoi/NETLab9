using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using My_ClassLibrary;

namespace cons11
{
    class myClass: Class1
    {
        int i = C;
    }
    class Program
    {
        static void Main(string[] args)
        {
            int i;
            Class1 cl1 = new Class1();
            myClass cl2 = new myClass();

            i = cl1.A;
            i = cl2.C;

        }
    }
}
