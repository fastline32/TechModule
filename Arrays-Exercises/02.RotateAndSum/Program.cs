using System;
using System.Linq;

namespace _02.RotateAndSum
{
    class Program
    {
        static void Main(string[] args)
        {
            var arrayOrigin = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int[] summArray = new int[arrayOrigin.Length];
            int[] reversed = new int[arrayOrigin.Length];

            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < arrayOrigin.Length; j++)
                {
                    if (j+1 < arrayOrigin.Length)
                    {
                        reversed[j+1] = arrayOrigin[j];
                    }
                    else
                    {
                        reversed[0] = arrayOrigin[j];
                    }
                }
                for (int j = 0; j < arrayOrigin.Length; j++)
                {
                    summArray[j] += reversed[j];
                }
                for (int j = 0; j < arrayOrigin.Length; j++)
                {
                    arrayOrigin[j] = reversed[j];
                }
            }
            Console.WriteLine(string.Join(" ", summArray));
        }
    }
}
