using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumbersInReversedOrder
{
    class NumbersInReversedOrder
    {
        static void Main()
        {
            Console.Write("n=");
            var n = int.Parse(Console.ReadLine());
            Console.WriteLine("The numbers are");
            for (var i = n; i >= 1; i-=1)
            {
                Console.WriteLine(i);
            }
        }
    }
}