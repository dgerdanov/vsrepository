using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CircleArea
{
     public class CircleAreaAndPerimeter
    {
         public static void Main()
        
        {
            Console.Write("r=");
            var r = double.Parse (Console.ReadLine());
            if (r <= 0)
            {
                Console.WriteLine("Ти си мега идиот");
                return;
            }
            
           var Area = Math.PI * r * r;
           var Perimeter = Math.PI * 2 * r;
            Console.Write("Area=");
            Console.WriteLine(Area);
            Console.Write("Perimeter=");
            Console.WriteLine(Perimeter);


        }
    }
}
