namespace _16.SumElement
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class SumElement
    {
        public static void Main()
        {
            var n = int.Parse(Console.ReadLine());
            var elements = new List<int>();

            for (int i = 0; i < n; i++)
            {
                var currentNumber = int.Parse(Console.ReadLine());
                elements.Add(currentNumber);
            }

            var biggestElement = elements.Max();
            elements.Remove(biggestElement);

            var sumWithoutMaxElemnt = elements.Sum();

            if(biggestElement == sumWithoutMaxElemnt)
            {
                Console.WriteLine("Yes");
                Console.WriteLine($"Sum = {sumWithoutMaxElemnt}");
            }
            else
            {
                Console.WriteLine("No");
                Console.WriteLine("Diff = {0}", Math.Abs(sumWithoutMaxElemnt - biggestElement));
            }
        }
    }
}
