using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_26
{
    class Program
    {
        static void Main(string[] args)
        {
            string x = "";
            string y = "Sololearn";

            foreach(char c in y)
            {
                if (c >= 'f')
                {
                    x += c;
                }
            }
            Console.WriteLine(x);
        }
    }
}
