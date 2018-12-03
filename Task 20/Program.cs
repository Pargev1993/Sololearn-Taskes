using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_20
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = "sololearn";
            string output = " ";
            int first = input.IndexOf('l');
            int last = input.IndexOf('e');
            for (int i = first; i < last; i++)
            {
                output += input[i];
            }
            Console.WriteLine(output);
        }
    }
}
