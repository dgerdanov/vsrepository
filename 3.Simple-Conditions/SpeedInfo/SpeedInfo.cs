using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpeedInfo
{
    class SpeedInfo
    {
        static void Main(string[] args)
        {
            var speed = double.Parse(Console.ReadLine());
            if (speed < 10)
            {
                Console.WriteLine("Slow");
            }
            else if (speed >= 10 && speed <= 50)
            {
                Console.WriteLine("Average");
            }
            else if (speed > 50 && speed <= 150)
            {
                Console.WriteLine("Fast");
            }
            else if (speed > 150 && speed <= 1000)
            {
                Console.WriteLine(" Ultra Fast");
            }
            else if (speed > 1000)
            {
                Console.WriteLine("You shit  your  pants");
            }
        }
    }
}
