using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeftAndRightSum
{
    class LeftAndRightSum
    {
        static void Main(string[] args)
        {
            Console.Write("n=");
            var n = int.Parse(Console.ReadLine());
            var sumLeft = 0;
            var sumRight = 0;
            for (int i = 0; i < n; i++)

            {
                sumLeft = sumLeft + int.Parse(Console.ReadLine());
            }
            for (int i = 0; i < n; i++)
            {
                sumRight = sumRight + int.Parse(Console.ReadLine());
            }
            if (sumLeft == sumRight)
            {
                
                Console.WriteLine("Yes, sum = " + sumLeft);
            }
            else
            {
                var difference = Math.Abs(sumRight - sumLeft);
                Console.WriteLine("No diff", difference);
            }
        }
    }
}
