using System;

namespace _02.SignOfIntegerNumber
{
    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            PrintSign(n);
        }

        static void PrintSign(int num)
        {
            if (num > 0)
                Console.WriteLine($"The number {num} is positive.");
            else if (num < 0)
                Console.WriteLine($"The number {num} is negative.");
            else
                Console.WriteLine($"The number {num} is zero.");
        }
    }
}
