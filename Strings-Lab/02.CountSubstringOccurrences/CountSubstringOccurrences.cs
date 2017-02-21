using System;

namespace _02.CountSubstringOccurrences
{
    class CountSubstringOccurrences
    {
        static void Main()
        {
            var text = Console.ReadLine().ToLower();
            var patern = Console.ReadLine().ToLower();

            int index = 0;
            int count = 0;

            while (true)
            {
                var found = text.IndexOf(patern, index);
                if (found >= 0)
                {
                    count++;
                    index = found + 1;
                }
                else
                {
                    break;
                }
            }
            Console.WriteLine(count);
        }
    }
}
