using System;

namespace _04.DrawAFilledSquare
{
    class DrawAFilledSquare
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            PrintFiledSqare(n);
        }

        static void PrintFiledSqare(int n)
        {
            Console.WriteLine(new string('-',n*2));
            for (int j = 1; j < n-1; j++)
            {
                Console.Write('-');
                for (int i = 0; i < n - 1; i++)
                {
                    Console.Write("\\/");
                }
                Console.WriteLine('-');
            }
            Console.WriteLine(new string('-', n * 2));
        }
    }
}
