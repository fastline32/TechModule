using System;

namespace _02.MaxMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1 = int.Parse(Console.ReadLine());
            int n2 = int.Parse(Console.ReadLine());
            int n3 = int.Parse(Console.ReadLine());

            Console.WriteLine(GetMax(n1,n2,n3));
        }

        static int GetMax(int one, int two, int three)
        {
            int max = Math.Max(one, Math.Max(two, three));
            return max;
        }
    }
}
