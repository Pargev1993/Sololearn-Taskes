using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_12
{
    class R
    {
         public int counter = 0;
        public R()
        {
            ++counter;
        }
        ~R()
        {
            --counter;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            R r = new R();
            Console.WriteLine(r.counter);
        }
    }
}
