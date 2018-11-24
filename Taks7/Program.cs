using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taks7
{
    class Program
    {
        static void Main(string[] args)
        {
            string x = " ";
            string y = "Sololearn";
            x += y.Substring(8, 1);
            x += y.Substring(5, 3);
            Console.WriteLine(x);
        }
    }
}
