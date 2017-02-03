using System;
using System.Collections.Generic;
using System.Linq;

namespace _01.RemoveNegativesAndReverse
{
    class Program
    {
        static void Main()
        {
            var line1 = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            List<int> line2 = new List<int>();

            for (int i = line1.Count -1 ; i >= 0; i--)
            {
                if (line1[i] > 0)
                {
                    line2.Add(line1[i]);
                }
            }
            Console.WriteLine(line2.Count == 0 ? "empty" : string.Join(" ", line2));
        }
    }
}
