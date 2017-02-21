using System;
using System.Collections.Generic;
using System.Linq;

namespace _04.Palindromes
{
    class Program
    {
        static void Main()
        {
            char[] charsSplit = new[] {' ', ',', '!', '?', '.'};
            var line = Console.ReadLine().Trim().Split(charsSplit,StringSplitOptions.RemoveEmptyEntries).ToList();
            List<string> result = new List<string>();
            foreach (var item in line)
            {
                
                if (item.SequenceEqual(item.Reverse()))
                {
                    result.Add(item);
                }
            }
            Console.WriteLine(string.Join(", ", result.OrderBy(x => x).Distinct()));
        }
    }
}
