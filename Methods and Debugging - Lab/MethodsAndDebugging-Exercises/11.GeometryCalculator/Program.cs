using System;

namespace _11.GeometryCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            string type = Console.ReadLine();
            GeometryCalc(type);
        }

        static void GeometryCalc(string type)
        {
            if (type == "triangle")
            {
                double side = double.Parse(Console.ReadLine());
                double height = double.Parse(Console.ReadLine());
                double result = Math.Round((side * height) / 2,2);
                Console.WriteLine(result);
            }
            if (type == "square")
            {
                double side = double.Parse(Console.ReadLine());
                double result = Math.Round((side * side), 2);
                Console.WriteLine(result);
            }
            if (type == "rectangle")
            {
                double side = double.Parse(Console.ReadLine());
                double height = double.Parse(Console.ReadLine());
                double result = Math.Round((side * height), 2);
                Console.WriteLine(result);
            }
            if (type == "circle")
            {
                double radius = double.Parse(Console.ReadLine());
                double result = Math.Round((Math.PI * radius * radius), 2);
                Console.WriteLine(result);
            }
        }
    }
}
