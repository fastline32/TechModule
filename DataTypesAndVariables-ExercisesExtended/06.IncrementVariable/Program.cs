using System;

namespace _06.IncrementVariable
{
    class IncrementVariable
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int count = 0;
            while (n >= 256)
            {
                count++;
                n -= 256;
            }
            Console.WriteLine(n);
            if (count > 0)
            {
                Console.WriteLine($"Overflowed {count} times");
            }
        }
    }
}
