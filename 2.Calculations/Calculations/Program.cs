using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RectangleArea
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("a=");
           var a = double.Parse(Console.ReadLine());
            Console.Write("b=");
            var b = double.Parse(Console.ReadLine());
            var area = a * b;
            Console.Write("Area=");
            Console.WriteLine(area);
            if (a <= 0)
            {
                Console.WriteLine("Not valid number");
              
            }

            else{

                a = double.Parse(Console.ReadLine());
            }
            if (b <= 0)
            {
                Console.WriteLine("Not valid number");

            }

            else
            {

                b = double.Parse(Console.ReadLine());
            }
            if (area <= 0)
            {
                Console.WriteLine("Area is not valid, please enter the correct values");
            }
            else
            {
                Console.Write("Area is:");   //!!!Когато тук е Console.WriteLine(area);  ми печата пресметнатото.

                Console.WriteLine(area);
            }





        }
    }
}
