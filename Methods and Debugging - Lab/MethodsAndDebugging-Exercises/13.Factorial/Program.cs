using System;
using System.Numerics;

namespace _13.Factorial
{
    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine(Factorial(n));
        }

        static BigInteger Factorial(BigInteger num)
        {
            BigInteger result = num;
            for (int i = 1; i < num; i++)
            {
                result = result * i;
            }
            return result;
        }
    }
}
