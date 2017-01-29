using System;
using System.Linq;

namespace _09.ExtractMiddleElements
{
    class Program
    {
        static void Main()
        {
            var n = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int start = n.Length / 2 - 1;
            if (n.Length % 2 == 0)
            {
                Console.Write("{ ");
                for (int i = 0; i < 2; i++)
                {
                    Console.Write(n[start] + ", ");
                    start++;
                }
                Console.WriteLine("}");
            }
            else if (n.Length == 1)
            {
                Console.Write("{ ");
                Console.Write("{0}", n[0]);
                Console.WriteLine(" }");
            }
            else
            {
                Console.Write("{ ");
                for (int i = 0; i <= 2; i++)
                {
                    Console.Write(n[start] + ", ");
                    start++;
                }
                Console.WriteLine("}");
            }
            Console.WriteLine();
        }
    }
}
