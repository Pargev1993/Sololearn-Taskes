using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task3
{
    class Program
    {

        public static string GetOne(string s, int i)
        {
            string[] split = s.Split(':');
            return split[i--];
        }


        static void Main(string[] args)
        {
            string s = "cat:dog:try:cry";
            int b = 2;
            Console.WriteLine(GetOne(s, ++b));
        }
    }
}
