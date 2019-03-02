using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetricConverter
{
    class Program
    {
        static void Main(string[] args)
        {
            double size = double.Parse(Console.ReadLine());

            string inpMet = Console.ReadLine().ToLower();

            string outMet = Console.ReadLine().ToLower();
            double meter = 0;
            double Result = 0;
            if (inpMet == "m")
            {
                meter = size / 1.0;
            }
            else if (inpMet == "mm")
            {
                meter = size / 1000;
            }
            else if (inpMet == "cm")
            {
                meter = size / 100;
            }
            else if (inpMet == "mi")
            {
                meter = size / 0.000621371192;
            }
            else if (inpMet == "in")
            {
                meter = size / 39.3700787;
            }
            else if (inpMet == "km")
            {
                meter = size / 0.001;
            }
            else if (inpMet == "ft")
            {
                meter = size / 3.2808399;
            }
            else if (inpMet == "yd")
            {
                meter = size / 1.0936133;
            }
            if (outMet == "m")
            {
                Result = meter * 1.0;
            }
            else if (outMet == "mm")
            {
                Result = meter * 1000;
            }
            else if (outMet == "cm")
            {
                Result = meter * 100;
            }
            else if (outMet == "mi")
            {
                Result = meter * 0.000621371192;
            }
            else if (outMet == "in")
            {
                Result = meter * 39.3700787;
            }
            else if (outMet == "km")
            {
                Result = meter * 0.001;
            }
            else if (outMet == "ft")
            {
                Result = meter * 3.2808399;
            }
            else if (outMet == "yd")
            {
                Result = meter * 1.0936133;
            }

            Console.WriteLine(Result);

        }
    }
}
