using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_21
{
    class Program
    {
        static int func(int a=3,int b=7,int c=6)
        {
            return a + b * c;
        }
        static void Main(string[] args)
        {
            int a = 4;
            int b = 5;
            int c = 2;
            Console.WriteLine(func(c,b));
        }
    }
}
