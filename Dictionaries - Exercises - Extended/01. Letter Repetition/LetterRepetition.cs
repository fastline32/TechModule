using System;
using System.Collections.Generic;

namespace _01.Letter_Repetition
{
    class LetterRepetition
    {
        static void Main()
        {
            string inputLine = Console.ReadLine();
            Dictionary<char,int> result = new Dictionary<char, int>();

            foreach (char item in inputLine)
            {
                if (!result.ContainsKey(item))
                {
                    result.Add(item,1);
                }
                else
                {
                    result[item]++;
                }
            }

            foreach (var kvp in result)
            {
                Console.WriteLine($"{kvp.Key} -> {kvp.Value}");
            }
        }
    }
}
