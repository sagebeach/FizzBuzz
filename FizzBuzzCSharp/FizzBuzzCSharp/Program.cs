﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzzCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i < 100; i++)
            {
                string s = null;

                if (i % 3 == 0)
                    s = "Fizz";

                if (i % 5 == 0)
                    s += "Buzz";

                Console.WriteLine(s ?? i.ToString());                
            }
        Console.Read();
        }
    }
}
