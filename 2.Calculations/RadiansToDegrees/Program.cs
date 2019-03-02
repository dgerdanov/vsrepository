using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace RadiansToDegrees
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Radians = ");
            var radians = double.Parse(Console.ReadLine());
            var degrees = radians * 180 / Math.PI;
            Console.Write("Degrees = ");
            Console.WriteLine(Math.Round(degrees, 2));

        }
    }
}