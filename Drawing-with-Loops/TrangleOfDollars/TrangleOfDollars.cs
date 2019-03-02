using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrangleOfDollars
{
   public class TrangleOfDollars
    {
        public static void Main()
        {
            var n = double.Parse(Console.ReadLine());
            for (int row = 1;  row < n; row++)
            {
                Console.Write("$");
                for (int col = 1 ;  col< row; col++)
                {
                    Console.Write(" $");
                }
                    Console.WriteLine();

            }
        }
    }
}
