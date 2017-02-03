using System;
using System.Linq;

namespace _07.CountNumbers
{
    class Program
    {
        static void Main()
        {
            var readLine = Console.ReadLine().Trim().Split(' ').Select(int.Parse).ToList();
            int[] result = new int[readLine.Max() + 1];
            int count = 1;

            foreach (var item in readLine)
            {
                if (result[item] != 0)
                {
                    result[item] = result[item]+1;
                }
                else
                {
                    result[item] = count;
                }
            }
            for (int i = 0; i < result.Length; i++)
            {
                if (result[i] != 0)
                {
                    Console.WriteLine("{0} => {1}", i, result[i]);
                }
            }
        }
    }
}
