using System;

namespace Cube_Properties
{
    class Cube_Properties
    {
        static void Main(string[] args)
        {
            double side = double.Parse(Console.ReadLine());
            string parameter = Console.ReadLine();
            double result = 0;

            switch (parameter)
            {
                case "face":
                    result = Math.Sqrt(Calculate(side, 2));
                    break;
                case "space":
                    result = Math.Sqrt(Calculate(side, 3));
                    break;
                case "volume":
                    result = Calculate(side, side);
                    break;
                case "area":
                    result = Calculate(side, 6);
                    break;
            }
            Console.WriteLine($"{Math.Round(result, 2):f2}");
        }

        static double Calculate(double side, double a)
        {
            return a * (side * side);
        }
    }
}