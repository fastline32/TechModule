using System;
using System.Collections.Generic;
using System.Linq;

namespace _04.SumReversedNumbers
{
    class Program
    {
        static void Main()
        {
            var inputLine = Console.ReadLine().Trim().Split(' ').Select(int.Parse).ToList();
            List<int> result = new List<int>();
            for (int i = 0; i < inputLine.Count; i++)
            {
                int reversed = 0;
                while (inputLine[i] > 0)
                {
                    int remainder = inputLine[i] % 10;
                    reversed = (reversed * 10) + remainder;
                    inputLine[i] = inputLine[i] / 10;
                }
                result.Add(reversed);
            }
            Console.WriteLine(result.Sum());
        }
    }
}
