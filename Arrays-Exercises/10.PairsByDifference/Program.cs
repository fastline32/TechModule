using System;
using System.Linq;

namespace _10.PairsByDifference
{
    class Program
    {
        static void Main()
        {
            int[] numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int n = int.Parse(Console.ReadLine());
            int counter = 0;

            for (int i = 0; i < numbers.Length; i++)
            {
                for (int k = i; k < numbers.Length; k++)
                {
                    if (Math.Abs(numbers[k] - numbers[i]) == n && i < k)
                    {
                        counter++;
                    }
                }
            }
            Console.WriteLine(counter);
        }
    }
}
