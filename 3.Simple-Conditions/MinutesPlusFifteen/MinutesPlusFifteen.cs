using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Време___15_минути
{
    class Program
    {
        static void Main(string[] args)
        {
            var hours = int.Parse(Console.ReadLine());
            var mins = int.Parse(Console.ReadLine());
            mins = mins + 15;

            if (mins > 59)
            {
                hours = hours + 1;
                mins = mins - 60;
            }
            if (hours > 23)
            {
                hours = 0;
            }

            if (mins < 10)
            {
                Console.WriteLine(hours + ":0" + mins);
            }
            else
                Console.WriteLine(hours + ":" + mins);


        }
    }
}