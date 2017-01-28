using System;

namespace _6.MathPower
{
    class Program
    {
        static void Main(string[] args)
        {
            double num = double.Parse(Console.ReadLine());
            double pow = double.Parse(Console.ReadLine());
            double result = MathPow(num, pow);
            Console.WriteLine(result);
        }

        static double MathPow(double number, double power)
        {
            return Math.Pow(number, power);
        }
    }
}
