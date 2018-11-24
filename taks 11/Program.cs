using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace taks_11
{
    class Program
    {
        static void Main(string[] args)
        {
            double d = 4.49 * 2;
            double c = Math.Ceiling(d);
            double r = Math.Round(d);
            double f = Math.Floor(d);
            Console.WriteLine(c+r+f);
        }
    }
}
