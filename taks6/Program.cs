using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace taks6
{
    class Class
    {
        public int x = 12;
        public int X
        {
            get { return ++x; }
            set { x = ++value; }

        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Class c = new Class();
            c.X = c.X;
            Console.WriteLine(c.X);
        }
    }
}
