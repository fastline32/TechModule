using System;
using System.Collections;

namespace _05.MagicExchangeableWords
{
    class MagicExchangeableWords
    {
        static void Main()
        {
            var line = Console.ReadLine().Trim().Split(' ');
            string line1 = line[0];
            string line2 = line[1];

            if (line1.Length >= line2.Length)
            {
                Console.WriteLine(IsExchangeble(line1, line2).ToString().ToLower());
            }
            else
            {
                Console.WriteLine(IsExchangeble(line2, line1).ToString().ToLower());
            }
            
        }

        public static bool IsExchangeble(string line1, string line2)
        {
            bool areEqual = true;
            var map = new Hashtable();
            if (line1.Length == line2.Length)
            {
                for (int i = 0; i < line1.Length; i++)
                {
                    if (!map.ContainsKey(line1[i]))
                    {
                        map.Add(line1[i], line2[i]);
                    }
                    else
                    {
                        if (!map.ContainsValue(line2[i]))
                        {
                            areEqual = false;
                        }
                    }
                }

            }
            else if (line1.Length > line2.Length)
            {
                for (int i = 0; i < line2.Length; i++)
                {
                    if (!map.ContainsKey(line1[i]))
                    {
                        map.Add(line1[i], line2[i]);
                    }
                    else
                    {
                        if (!map.ContainsValue(line2[i]))
                        {
                            areEqual = false;
                        }
                    }
                }
                for (int i = line2.Length; i < line1.Length; i++)
                {
                    if (!map.ContainsKey(line1[i]))
                    {
                        areEqual = false;
                    }
                }
            }
          
            return areEqual;
        }
    }
}
