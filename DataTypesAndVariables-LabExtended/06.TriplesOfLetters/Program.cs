using System;

namespace TriplesOfLetters
{
    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            for (int i = 97; i < 97 + n; i++)
            {
                for (int j = 97; j < 97 + n; j++)
                {
                    for (int k = 97; k < 97 + n; k++)
                    {
                        Console.WriteLine("{0}{1}{2}", (char)i, (char)j, (char)k);
                    }
                }
            }
        }
    }
}
