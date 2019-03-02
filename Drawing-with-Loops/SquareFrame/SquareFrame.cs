using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SquareFrame
{
    class SquareFrame
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            Console.Write("+ ");
            for (int endrow = 1; endrow <= n - 2; endrow++)
            {
                Console.Write("-");
            }
            Console.WriteLine(" +");
            for (int i = 1; i <= n - 2; i++)
            {
                Console.Write("| ");
                for (int midrow = 1; midrow <= n - 2; midrow++)
                {
                    Console.Write("-");
                }
                Console.WriteLine(" |");
            }
            Console.Write("+ ");
            for (int endrow = 1; endrow <= n - 2; endrow++)
            {
                Console.Write("-");
            }
            Console.WriteLine(" +");
        }
    }
}