using System;
using System.Numerics;

namespace _03.BigFactorial
{
    class Program
    {
        static void Main()
        {
            // ReSharper disable once AssignNullToNotNullAttribute
            var n = int.Parse(Console.ReadLine());
            BigInteger fact = 1;
            for (int i = 2; i <= n; i++)
            {
                fact = fact * i;
            }
            Console.WriteLine(fact);
        }
    }
}
