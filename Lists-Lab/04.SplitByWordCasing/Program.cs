using System;
using System.Collections.Generic;
using System.Linq;

namespace _04.SplitByWordCasing
{
    class CountNumber
    {
        static void Main()
        {
            var readLine = Console.ReadLine();
            if (readLine != null)
            {
                List<string> words = readLine.Split(new[] { ' ', ',', ';', ':', '.', '!', '(', ')', '"', '\'', '/', '\\', '[', ']' },
                    StringSplitOptions.RemoveEmptyEntries).ToList();
                List<string> lowerCase = new List<string>();
                List<string> mixedCase = new List<string>();
                List<string> upperCase = new List<string>();
                foreach (var word in words)
                {
                    bool isAllLowerCase = true;
                    bool isAllUpperrCase = true;
                    foreach (char t in word)
                    {
                        if (char.IsLower(t))
                        {
                            isAllUpperrCase = false;
                        }
                        else if (char.IsUpper(t))
                        {
                            isAllLowerCase = false;
                        }
                        else
                        {
                            isAllLowerCase = false;
                            isAllUpperrCase = false;
                        }
                    }
                    if (isAllLowerCase)
                    {
                        lowerCase.Add(word);
                    }
                    else if (isAllUpperrCase)
                    {
                        upperCase.Add(word);
                    }
                    else
                    {
                        mixedCase.Add(word);
                    }
                }
                Console.WriteLine("Lower-case: {0}", string.Join(", ", lowerCase));
                Console.WriteLine("Mixed-case: {0}", string.Join(", ", mixedCase));
                Console.WriteLine("Upper-case: {0}", string.Join(", ", upperCase));
            }
        }
    }
}