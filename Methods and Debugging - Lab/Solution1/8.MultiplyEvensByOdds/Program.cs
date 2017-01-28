using System;

namespace _8.MultiplyEvensByOdds
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = Math.Abs(int.Parse(Console.ReadLine()));
            int result = GetMultipleOfEvenAndOdd(n);
            Console.WriteLine(result);
        }
        static int GetMultipleOfEvenAndOdd(int n)
        {
            int sumEven = GetSumOfEven(n);
            int sumOdd = GetSumOfOdd(n);
            return sumEven * sumOdd;

        }
        static int GetSumOfEven(int n)
        {
            int sum = 0;
            while (n >0)
            {
                int lastDigit = n % 10;
                if (lastDigit % 2  == 0)
                {
                    sum += lastDigit;
                }
                n /= 10;
            }
            return sum;
        }

        static int GetSumOfOdd(int n)
        {
            int sum = 0;
            while (n > 0)
            {
                int lastDigit = n % 10;
                if (lastDigit % 2  != 0)
                {
                    sum += lastDigit;
                }
                n /= 10;
            }
            return sum;
        }
    }
}
