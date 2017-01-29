using System;
using System.Linq;

namespace _04.TrippleSum
{
    class Program
    {
        static void Main()
        {
            int[] n = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int count = 0;
            for (int i = 0; i < n.Length; i++)
            {
                for (int j = i + 1; j < n.Length; j++)
                {
                    int a = n[i];
                    int b = n[j];
                    int sum = a + b;
                    if (n.Contains(sum))
                    {
                        Console.WriteLine("{0} + {1} == {2}", a, b, sum);
                        count++;
                    }
                }
            }
            if (count == 0)
            {
                Console.WriteLine("No");
            }
        }
    }
}
