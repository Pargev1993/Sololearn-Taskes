using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sololearn_Taskes
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] Arr = { 7, 4, 3 };
            int m = 1;
            try
            {
                m = Arr[3];
                Console.WriteLine(m);
            }
            catch 
            {

                m = Arr[m];
            }
            Console.WriteLine(m);

        }
    }
}
