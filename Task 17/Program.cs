using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_17
{
    struct F
    {
        public int i;
    }
    class Program
    {
        static void Main(string[] args)
        {
            F x = new F();
            x.i = 10;
            fun(ref x);
            Console.WriteLine(x.i);
        }
        public static void fun (ref F y)
        {
            y.i = 20;
            Console.WriteLine(y.i);
        }
    }
   
}
