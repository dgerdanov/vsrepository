using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoopByStep3
{
    class LoopByStep3
    {
        static void Main()
        {
            Console.Write("n=");
            var n = int.Parse(Console.ReadLine());
            Console.WriteLine("The numbers are");
            for (int i = 0; i <= n; i+=3)
            {
                Console.WriteLine(i);
            }
        }
    }
}
