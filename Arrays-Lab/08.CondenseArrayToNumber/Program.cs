using System;
using System.Linq;

namespace _08.CondenseArrayToNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] line = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            if (line.Length > 1)
            {
                int[] condensed = new int[line.Length - 1];
                for (int i = condensed.Length; i > 0; i--)
                {
                    for (int j = 0; j < condensed.Length; j++)
                    {
                        condensed[j] = line[j] + line[j + 1];
                        line[j] = condensed[j];
                    }
                }
                Console.WriteLine(condensed[0]);
            }
            else
            {
                Console.WriteLine(line[0]);
            }
        }
    }
}
