using System;

namespace _14.ASCIIString
{
    class ASCIIString
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            string finalString = "";
            for (int i = 0; i < n; i++)
            {
                int charNum = int.Parse(Console.ReadLine());
                finalString += (char)charNum;
            }
            Console.WriteLine(finalString);
        }
    }
}
