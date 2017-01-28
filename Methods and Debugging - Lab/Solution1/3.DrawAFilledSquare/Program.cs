using System;

namespace _3.DrawAFilledSquare
{
    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            PrintSquare(n);
        }

        static void PrintSquare(int num)
        {
            Console.WriteLine(new string('-', 2 * num));
            for (int i = 0; i < num-2; i++)
            {
                Console.Write("-");
                for (int j = 1; j < num; j++)
                {
                    Console.Write("\\/");
                }
                Console.WriteLine("-");
            }
            Console.WriteLine(new string('-', 2*num));
        }
    }
}
