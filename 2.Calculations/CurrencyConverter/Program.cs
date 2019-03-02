using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CurrencyConverter2
{
    class Currency_Converter
    {
        static void Main(string[] args)
        {
            double num = double.Parse(Console.ReadLine());
            var first = Console.ReadLine().ToUpper();//ToLower -прави текста в малки букви
            var second = Console.ReadLine().ToUpper();

            if (first == "USD")
            {
                if (second == "BGN")
                {
                    Console.WriteLine("{0}", Math.Round(num * 1.79549, 2));
                }
                else if (second == "EUR")
                {
                    Console.WriteLine("{0}", Math.Round(num * 0.91801, 2));
                }
                else if (second == "GBP")
                {
                    Console.WriteLine("{0}", Math.Round(num * 0.70854, 2));
                }

            }

            if (first == "BGN")
            {
                if (second == "USD")
                {
                    Console.WriteLine("{0}", Math.Round(num / 1.79549, 2));
                }
                else if (second == "EUR")
                {
                    Console.WriteLine("{0}", Math.Round(num / 1.95583, 2));
                }
                else if (second == "EUR")
                {
                    Console.WriteLine("{0}", Math.Round(num / 2.53405, 2));
                }
            }

            if (first == "EUR")
            {
                if (second == "BGN")
                {
                    Console.WriteLine("{0}", Math.Round(num * 2.53405, 2));
                }
                else if (second == "USD")
                {
                    Console.WriteLine("{0}", Math.Round(num * 1.08930, 2));
                }
                else if (second == "GBP")
                {
                    Console.WriteLine("{0}", Math.Round(num * 0.77181, 2));
                }
            }
            if (first == "GBP")
                if (second == "BGN")
                {
                    Console.WriteLine("{0}", Math.Round(num * 0.39462, 2));
                }
                else if (second == "USD")
                {
                    Console.WriteLine("{0}", Math.Round(num * 2.53405 / 1.79549, 2));//Тука беше разликата.
                }
                else if (second == "EUR")
                {
                    Console.WriteLine("{0}", Math.Round(num * 0.77181, 2));
                }
        }
    }
}