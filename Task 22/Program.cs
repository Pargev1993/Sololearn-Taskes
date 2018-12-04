using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_22
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = " ";
            char[] arr = new char[]
                {'x','y','z','e','d'};
            foreach(char c in arr)
            {
                if (c <= 'x')
                    s += c;
            }
            Console.WriteLine(s);
        }
    }
}
