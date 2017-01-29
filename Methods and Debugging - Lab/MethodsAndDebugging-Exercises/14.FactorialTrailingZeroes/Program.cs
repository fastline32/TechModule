using System;
using System.Numerics;

namespace _14.FactorialTrailingZeroes
{
    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            BigInteger result = Factorial(n);
            Console.WriteLine(ZeroCounter(result));
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

        static BigInteger ZeroCounter(BigInteger num)
        {
            int count = 0;
            while (num % 10 == 0)
            {
                count++;
                num /= 10;
            }
            return count;
        }
    }
}
