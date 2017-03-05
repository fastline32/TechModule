using System;
using System.Collections.Generic;

namespace _03.Mixed_Phones
{
    class MixedPhones
    {
        static void Main()
        {
            string inputLine = Console.ReadLine();
            SortedDictionary<string,long> result = new SortedDictionary<string, long>();

            while (inputLine != "Over")
            {
                var token = inputLine.Trim().Split(new []{' '},StringSplitOptions.RemoveEmptyEntries);
                var entity1 = token[0];
                var entity2 = token[token.Length-1];

                long phone = 0;

                var test = long.TryParse(entity1, out phone);
                if (test)
                {
                    result.Add(entity2,phone);
                }
                else
                {
                    result.Add(entity1,long.Parse(entity2));
                }
                inputLine = Console.ReadLine();
            }
            foreach (var pair in result)
            {
                Console.WriteLine($"{pair.Key} -> {pair.Value}");
            }
        }
    }
}
