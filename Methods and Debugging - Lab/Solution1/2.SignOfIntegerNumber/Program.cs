using System;

namespace _2.SignOfIntegerNumber
{
    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            PrintSign(n);
        }

        static void PrintSign(int num)
        {
            if (num > 0)
            {
                Console.WriteLine("The number {0} is positive.",num);
            }
            else if (num == 0)
            {
                Console.WriteLine("The number 0 is zero.");                
            }
            else
            {
                Console.WriteLine("The number {0} is negative.", num);
            }
        }
    }
}
