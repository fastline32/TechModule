using System;
using System.Linq;

namespace _07.SumArrays
{
    class Program
    {
        static void Main()
        {
            int[] n = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int[] m = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            for (int i = 0; i < Math.Max(n.Length, m.Length); i++)
            {
                int k = n[i % n.Length];
                int j = m[i % m.Length];
                int sum = k + j;
                Console.Write(sum + " ");
            }
            Console.WriteLine();
        }
    }
}
