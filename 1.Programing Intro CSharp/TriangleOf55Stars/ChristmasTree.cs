using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TriangleOf55Stars
{
    public class ChristmasTree
    {
        public static void Main()
        {
            var n = int.Parse(Console.ReadLine());

            if (n < 0)
            {
                Console.WriteLine("Impossible mate");
            }

            for (int i = 0; i <= n; i++)
            {
                Console.Write(new string(' ', n - i));
                Console.Write(new string('*', i));
                Console.Write('|');
                Console.WriteLine(new string('*', i));
            }
        }
    }
}
