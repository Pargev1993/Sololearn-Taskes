﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task5
{
    class Program
    {
        static void Main(string[] args)
        {
            int sum = 0;
            for (int i = 5; i > 0; i--)
                for (int j = 0; j < i; j++)
                    sum += j;
            Console.WriteLine(sum);
        }
    }
}
