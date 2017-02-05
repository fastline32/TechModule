using System;

namespace _04.NthDigit
{
    class NthDigit
    {
        static void Main()
        {
            Console.WriteLine(FindDigit());
        }

        static long FindDigit()
        {
            long searchingDigit = 0;
            long num = long.Parse(Console.ReadLine());
            int index = int.Parse(Console.ReadLine());
            for (int i = 0; i < index; i++)
            {
                searchingDigit = num % 10;
                num /= 10;
            }
            return searchingDigit;
        }
    }
}
