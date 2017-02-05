using System;

namespace _06.MathPower
{
    class MathPower
    {
        static void Main()
        {
            double num = Double.Parse(Console.ReadLine());
            int power = int.Parse(Console.ReadLine());
            Console.WriteLine(MathPow(num,power));
        }

        static double MathPow(double num, int power)
        {
            return Math.Pow(num, power);
        }
    }
}
