using System;

class CheckIfPrime
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter integer: ");
        int CheckedInt = int.Parse(Console.ReadLine());
        for (int i = 1; i < CheckedInt + 1; i++)
        {
            if (CheckedInt % i == 0)
            {
                if (i == CheckedInt)
                {
                    Console.WriteLine("The entered integer is prime");
                }
                else if (i == 1)
                {
                    continue;
                }
                else
                {
                    Console.WriteLine("The entered integer is NOT prime");
                    break;
                }
            }
        }
    }
}