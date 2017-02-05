using System;

namespace _02.MinMethod
{
    class Program
    {
        static void Main()
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());

            Console.WriteLine(GetMin(a,b,c));
        }

        static int GetMin(int a, int b, int c)
        {
            int min = Math.Min(a, Math.Min(b, c));
            return min;
        }
    }
}
