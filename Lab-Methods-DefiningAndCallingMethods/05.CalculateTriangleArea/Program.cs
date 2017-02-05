using System;

namespace _05.CalculateTriangleArea
{
    class CalculateTriangleArea
    {
        static void Main()
        {
            double widt = double.Parse(Console.ReadLine());
            double height = double.Parse(Console.ReadLine());

            Console.WriteLine(TriangleArea(widt, height));
        }

        static double TriangleArea(double widt, double height)
        {
            return widt * height / 2;
        }
    }
}
