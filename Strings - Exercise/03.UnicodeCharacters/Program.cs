using System;

namespace _03.UnicodeCharacters
{
    class Program
    {
        static void Main()
        {
            string inputLine = Console.ReadLine();
            string result = "";

            foreach (char item in inputLine)
            {
                result += GetEscape(item);
            }
            Console.WriteLine(result);
        }

        public static string GetEscape(char a)
        {
            return "\\u" + ((int) a).ToString("X4").ToLower();
        }
    }
}
