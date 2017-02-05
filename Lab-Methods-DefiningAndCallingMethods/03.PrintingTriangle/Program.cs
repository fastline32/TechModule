using System;

namespace _03.PrintingTriangle
{
    class PrintingTriangle
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            UpperTriangle(1,n);
            DownTriangle(n);
        }

        static void UpperTriangle(int start, int end)
        {
            start = 1;
            for (int i = start; i < end; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write(j + " ");
                }
                Console.WriteLine();
            }
            
        }

        static void DownTriangle(int end)
        {
            for (int i = end; i >= 1; i--)
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
