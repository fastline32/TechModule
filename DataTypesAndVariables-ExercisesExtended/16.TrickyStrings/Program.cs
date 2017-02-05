using System;

namespace _16.TrickyStrings
{
    class TrickyStrings
    {
        static void Main()
        {
            string delimiter = Console.ReadLine();
            string finalString = "";
            int wordNumbers = int.Parse(Console.ReadLine());
            for (int i = 0; i < wordNumbers-1; i++)
            {
                string word = Console.ReadLine();
                finalString += word;
                finalString += delimiter;
            }
            string word1 = Console.ReadLine();
            finalString += word1;
            Console.WriteLine(finalString);
        }
    }
}
