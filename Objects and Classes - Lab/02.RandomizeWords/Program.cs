using System;
using System.Linq;

namespace _02.RandomizeWords
{
    class Program
    {
        static void Main()
        {
            var readLine = Console.ReadLine();
            if (readLine != null)
            {
                var words = readLine.Split(' ').ToArray();
                Random rnd = new Random();
                for (int pos = 0; pos < words.Length; pos++)
                {
                    var randomPos = rnd.Next(words.Length);
                    var oldWord = words[pos];
                    words[pos] = words[randomPos];
                    words[randomPos] = oldWord;
                }
                Console.WriteLine(string.Join("\r\n", words));
            }
        }
    }
}
