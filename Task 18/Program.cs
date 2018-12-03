using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_18
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] valus = { 1, 2, 3 };
            for (int x = 0, y = valus.Length - 1; ((x < valus.Length) && (y >= 0)); x++,y--)
            {
                Console.WriteLine(valus[x]);
                Console.WriteLine(valus[y]);
            }
        }
    }
}
