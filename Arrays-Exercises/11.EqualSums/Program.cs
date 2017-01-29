using System;
using System.Linq;

namespace _11.EqualSums
{
    class Program
    {
        static void Main()
        {
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();

            if (SumIsZero(numbers))
            {
                Console.WriteLine(0);
            }
            else
            {
                bool sumDoesNotExist = true;
                for (int i = 0; i < numbers.Length; i++)
                {
                    if (LeftSum(i, numbers) == RightSum(i, numbers))
                    {
                        Console.WriteLine(i);
                        sumDoesNotExist = false;
                        break;
                    }
                }

                if (sumDoesNotExist)
                {
                    Console.WriteLine("no");
                }
            }
        }

        public static bool SumIsZero(int[] numbers)
        {
            if (numbers.Length == 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static int LeftSum(int i, int[] numbers)
        {
            int sum = 0;
            for (int x = 0; x < i; x++)
            {
                sum += numbers[x];
            }

            return sum;
        }

        public static int RightSum(int i, int[] numbers)
        {
            int sum = 0;
            for (int x = i + 1; x < numbers.Length; x++)
            {
                sum += numbers[x];
            }

            return sum;
        }
    }
}
