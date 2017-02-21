using System;
using System.Collections.Generic;
using System.Linq;

namespace _01.ReverseString
{
    class ReverseString
    {
        static void Main()
        {
            var inputLine = Console.ReadLine();
            List<char> reversed = inputLine.ToList();
            string outputLine = "";

            for (int i = reversed.Count - 1; i >= 0; i--)
            {
                outputLine += (char)reversed[i];
            }
            Console.WriteLine(outputLine);
        }
    }
}
