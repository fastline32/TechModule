using System;

namespace _16.ComparingFloats
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal num1 = decimal.Parse(Console.ReadLine());
            decimal num2 = decimal.Parse(Console.ReadLine());

            decimal eps = 0.000001m;

            if (Math.Abs(num1-num2) < eps)
            {
                Console.WriteLine(true);
            }
            else
            {
                Console.WriteLine(false);
            }
        }
    }
}
