
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_16
{
    class Myclass
    {
        public int x = 10;
        public int y = 11;
        public Myclass()
        {
            x += 12;
            y += 13;
        }
        ~Myclass()
        {
            x += 18;
            y += 15;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Myclass c = new Myclass();
            Console.WriteLine(c.x+c.y);
        }
    }
}
