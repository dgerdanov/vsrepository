using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FruitOrVegetable
{
    class Program
    {
        static void Main(string[] args)
        {
            string thing = Console.ReadLine();
            string[] fruits = { "banana", "apple", "kiwi", "cherry", "lemon", "grapes" };
            string[] vegetables = { "banana", "apple", "kiwi", "cherry", "lemon", "grapes" };
            if (Array.Exists(fruits, element => element == thing))
            {
                Console.WriteLine("Fruit");
            }
            else if (Array.Exists(vegetables, element => element == thing))
            {
                Console.WriteLine("Vegetable");
            }
            else
            {
                Console.WriteLine("unknown");
            }
        }
    }
}


    

