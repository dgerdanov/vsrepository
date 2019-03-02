using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConverterFromCelciusToFarenheit
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("°C =");
            var celsius = double.Parse(Console.ReadLine());
            var farenheit = (celsius * 1.8 + 32);
            Console.Write("°F =");
            Console.WriteLine (Math.Round(farenheit, 2));

        }
    }
}
