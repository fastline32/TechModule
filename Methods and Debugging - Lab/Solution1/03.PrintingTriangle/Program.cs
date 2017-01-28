using System;

namespace _03.PrintingTriangle
{
    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            PrintTriangle(n);
        }

        static void PrintTriangle(int num)
        {
            for (int i = 1; i <= num; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write(j + " ");
                }
                Console.WriteLine();
            }
            for (int i = num - 1; i >=1 ; i--)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write(j + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
