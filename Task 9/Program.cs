using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_9
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = "012345";
            str = str.Substring(0);
            str = str.Substring(2);
            str = str.Substring(0, 3);
            str = str.Substring(1, 2);
            Console.WriteLine(str);
        }
    }
}
