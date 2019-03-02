using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Сумиране_на_секунди
{
    class Program
    {
        static void Main(string[] args)
        {
            var sec1 = int.Parse(Console.ReadLine());

            var sec2 = int.Parse(Console.ReadLine());

            var sec3 = int.Parse(Console.ReadLine());

            var secs = sec1 + sec2 + sec3;
            var mins = 0;

            if (0 <= secs && secs <= 59)
            {
                mins = 0;
            }
            else if (60 <= secs && secs <= 119)
            {
                mins = 1; secs = (secs - 60);
            }
            else if (120 <= secs && secs <= 179)
            {
                mins = 2; secs = (secs - 120);
            }
            if (secs < 10)
            {
                Console.WriteLine(mins + ":0" + secs);
            }
            else
                Console.WriteLine(mins + ":" + secs);

        }
    }
}

