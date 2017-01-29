using System;
using System.Linq;

namespace _04.SieveOfEratosthenes
{
    class Program
    {
        static void Main(string[] args)
        {

            int n = int.Parse(Console.ReadLine());
            int cur = 1, total = n;
            var pc = Enumerable.Range(2, total).ToList();

            while (cur <= Math.Sqrt(total))
            {
                cur = pc.First(i => i > cur);
                pc.RemoveAll(i => i != cur && i % cur == 0);
            }
            if (pc.Max() > n)
            {
                for (int i = 0; i < pc.Count -1; i++)
                {

                    Console.Write(pc[i] + " ");
                }
            }
            else
            {
                for (int i = 0; i < pc.Count; i++)
                {
                Console.Write(pc[i] + " ");
                }
            }
        }
    }
}
