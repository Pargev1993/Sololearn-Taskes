using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] Arr = { 1, 2, 3 };
            int y = 0;
            foreach (int elem in Arr) 
            {
                y += elem;
            }
            Console.WriteLine(y);
        }
    }
}
