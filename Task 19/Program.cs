using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_19
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 0;
            int[][] arr=
            {
                new int []{0},
                new int []{1,3,5,7,9},
                new int []{2,4,6,8}

            };
            x += arr[2][1];
            x += arr[2][3]*10;
            x += arr[1][4] * 100; 
            x += arr[1][0]*1000;
            Console.WriteLine(x);
            Console.WriteLine(1/0.0);

        }
    }
}
