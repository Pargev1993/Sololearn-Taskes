using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_14
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 1;
            int[,] m = new int[,]
            {
            {2,1,3 },
            { 3,5,4},
            { 4,3,5}
            };
            for (int i = 0; i <= 2; i++)
            {
                x *= m[i, 2 - i];
                Console.WriteLine(x
                    );

            }


        }
    }
}
