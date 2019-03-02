using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrapezoidArea
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Write("a=");
            var a = double.Parse(Console.ReadLine());
            if (a <= 0)
            {
                Console.WriteLine("Ти си тъпанар ");
                return;
            }
            Console.Write("b=");
            var b = double.Parse(Console.ReadLine());
            if (b <= 0)
            {
                Console.WriteLine("Ти си тъпанар ");
                return;
            }
            Console.Write("h=");
            var h = double.Parse(Console.ReadLine());
            if (h <= 0)
            {
                Console.WriteLine("Ти си тъпанар ");
                return;
            }
            var TrapezoidArea = (a * b) / 2 * h;
            Console.Write("Area=");
            Console.WriteLine(TrapezoidArea);
            }
        }
    }
