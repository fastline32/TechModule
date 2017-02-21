using System;
using System.Collections.Generic;
using System.Linq;

namespace _03.TextFilter
{
    class TextFilter
    {
        static void Main()
        {
            var bannedWords = Console.ReadLine().Split(new [] {',', ' '}).ToArray();
            var text = Console.ReadLine();
            var words = new List<string>();
            foreach (var item in bannedWords)
            {
                if (item.Length > 0)
                {
                    words.Add(item);
                }
            }

            foreach (var word in words)
            {
                text = text.Replace(word, new string('*', word.Length));
            }

            Console.WriteLine(text);
        }
    }
}
