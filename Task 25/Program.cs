using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_25
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 5; i++)
            {
                if (i == 2)
                {
                    Console.WriteLine(i);
                }
                if (i % 2 == 1)
                {
                    Console.WriteLine(i);
                    break;
                }
                Console.WriteLine(i);
                continue;
            }
        }
    }
}
