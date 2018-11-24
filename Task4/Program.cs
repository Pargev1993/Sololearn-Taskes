using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    class Program
    {
        static void Main(string[] args)
        {
            int foo = 1;
            for (int x = 5; x <= 50; x++)
            {
                foo *= x;
                for (int y = 1; y <= 5; y++)
                {
                    if (x == y)
                        goto bar;
                    foo *= y;
                            
                }
            }
        bar: Console.WriteLine(foo);
        }
    }
}
