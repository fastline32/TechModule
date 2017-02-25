using System;

namespace CircleArea
{
    class Program
    {
        static void Main()
        {
            double r = double.Parse(Console.ReadLine());
            Console.WriteLine("{0:f12}", Math.PI * r * r);
        }
    }
}