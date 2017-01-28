using System;

namespace _12.RectangleProperties
{
    class Program
    {
        static void Main()
        {
            double width = double.Parse(Console.ReadLine());
            double height = double.Parse(Console.ReadLine());

            double area = width * height;
            double perimeter =2 * (width + height);
            double diagonal = Math.Sqrt((width * width) + (height * height));

            Console.WriteLine(perimeter);
            Console.WriteLine(area);
            Console.WriteLine(diagonal);
        }
    }
}
