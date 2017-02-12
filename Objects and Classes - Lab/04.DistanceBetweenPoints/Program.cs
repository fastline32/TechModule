using System;
using System.Linq;

namespace _04.DistanceBetweenPoints
{
    class Point
    {
        public int X  { get; set; }
        public int Y { get; set; }
    }
    class Program 
    {
        static void Main()
        {
            var point1 = Console.ReadLine().Split(' ').ToArray();
            var point2 = Console.ReadLine().Split(' ').ToArray();
            Point p1 = new Point();
            p1.X = int.Parse(point1[0]);
            p1.Y = int.Parse(point1[1]);
            Point p2 = new Point();
            p2.X = int.Parse(point2[0]);
            p2.Y = int.Parse(point2[1]);
            Console.WriteLine("{0:f3}",CalcDistance(p1,p2));

        }
        static double CalcDistance(Point p1, Point p2)
        {
            var a = p1.X - p2.X;
            var b = p1.Y - p2.Y;
            var c = Math.Sqrt(a * a + b * b);
            return c; 
        }
    }
}
