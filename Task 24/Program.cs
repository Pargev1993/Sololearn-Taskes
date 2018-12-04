using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_24
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 1;
            int[] arr = new int[]
                {9,4,5};
            foreach (int i in arr)
            {
                if (i % 2 == 0)
                    x /= i;
                else
                    x *= i;
            }
            Console.WriteLine(x);
           
        }
    }
}
