﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PowToN
{
    class PowToN
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            int num = 1;  
            for (int i = 0; i <= n; i++)
            {
                {
                    Console.WriteLine(num);
                    num = num * 2;
                }

            }
        }
    }
}
