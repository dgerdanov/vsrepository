﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Greeting
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Write your name, please:");
            var Name = Console.ReadLine();
            Console.WriteLine("Hello, {0} !",Name);
        }
    }
}
