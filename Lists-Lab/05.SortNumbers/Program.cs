using System;
using System.Linq;

namespace _05.SortNumbers
{
    class Program
    {
        static void Main()
        {
            var readLine = Console.ReadLine();
            if (readLine != null)
            {
                var line = readLine.Split(' ').Select(decimal.Parse).ToList();
                line.Sort();
                Console.WriteLine(string.Join(" <= ", line));
            }
        }
    }
}
