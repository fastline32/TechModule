using System;

namespace _15.FastPrimeChecker_Refactor
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            for (int number = 2; number <= n; number++)
            {
                bool isPrime = true;
                for (int devider = 2; devider <= Math.Sqrt(number); devider++)
                {
                    if (number % devider == 0)
                    {
                        isPrime = false;
                        break;
                    }
                }
                Console.WriteLine($"{number} -> {isPrime}");
            }

        }
    }
}
