using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace _03.WordCount
{
    class Program
    {
        static void Main()
        {
            var words = File.ReadAllText("words.txt").Split(new[] {' '}, StringSplitOptions.RemoveEmptyEntries)
                                                                .Select(w => w.ToLower()).ToArray();

            var textWords = File.ReadAllText("text.txt").Split(new[] {' ','.',',','-','?','!', '\n', '\r' } ,
                                                                StringSplitOptions.RemoveEmptyEntries).Select(w => w.ToLower())
                                                                .ToArray();

            var result = new Dictionary<string,int>();

            for (int i = 0; i < textWords.Length; i++)
            {
                var textWordCount = 0;
                for (int j = 0; j < words.Length; j++)
                {
                    if (textWords[i] == words[j])
                    {
                        if (!result.ContainsKey(textWords[i]))
                        {
                            textWordCount++;
                            result.Add(textWords[i],textWordCount);
                        }
                        else
                        {
                            result[textWords[i]]++;
                        }
                    }
                }
            }
            
            var sortedResult = result.OrderByDescending(kvp => kvp.Value).Select(kvp => $"{kvp.Key} - {kvp.Value}").ToArray();
            File.WriteAllLines("result.txt",sortedResult);
        }
    }
}
