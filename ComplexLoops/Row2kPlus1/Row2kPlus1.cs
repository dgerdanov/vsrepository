﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Row2kPlus1
{
    class Row2kPlus1
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            int num = 1; 
            while (num <= n)
            {
                Console.WriteLine(num);
                num = 2 * num + 1;
            }

        }
    }
}
