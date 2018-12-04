using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_23
{
    class Program
    {
        static void Main(string[] args)
        {
            string animal;
            Stack<string> animals = new Stack<string>();
            animals.Push("Panda");
            animals.Push("zebra");
            animals.Push("tiger");
            animal = animals.Pop();
            animals.Push("sleep");
            animal = animals.Pop();
            Console.WriteLine(animal);
        }
    }
}
