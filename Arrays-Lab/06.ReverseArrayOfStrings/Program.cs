using System;
using System.Linq;

namespace _06.ReverseArrayOfStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            var line = Console.ReadLine().Split(' ').ToArray().Reverse();
            Console.WriteLine(string.Join(" ", line));
        }
    }
}
