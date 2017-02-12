using System;

namespace _03.CirclesIntersection
{
    class Point
    {
        public int X { get; set; }
        public int Y { get; set; }
    }
    class Circle
    {
        public Point center { get; set; }
        public int radius { get; set; }
    }
    class Program
    {
        static void Main()
        {
            var lineOne = Console.ReadLine().Split(' ');
            Point circleOneCenter = new Point();
            circleOneCenter.X = int.Parse(lineOne[0]);
            circleOneCenter.Y = int.Parse(lineOne[1]);
            Circle circleOne = new Circle();
            circleOne.center = circleOneCenter;
            circleOne.radius = int.Parse(lineOne[2]);

            var lineTwo = Console.ReadLine().Split(' ');
            Point circleTwoCenter = new Point();
            circleTwoCenter.X = int.Parse(lineTwo[0]);
            circleTwoCenter.Y = int.Parse(lineTwo[1]);
            Circle circleTwo = new Circle();
            circleTwo.center = circleOneCenter;
            circleTwo.radius = int.Parse(lineTwo[2]);

            if (Intersect(circleOneCenter, circleTwoCenter,circleOne, circleTwo) == true)
            {
                Console.WriteLine("Yes");
            }
            else
            {
                Console.WriteLine("No");
            }
        }

        static double CalculateDistance(Point p1, Point p2)
        {
            var a = p1.X - p2.X;
            var b = p1.Y - p2.Y;
            double result = Math.Sqrt(a * a + b * b);
            return result;
        }

        static bool Intersect(Point p1, Point p2 , Circle c1, Circle c2 )
        {
            var distance = CalculateDistance(p1, p2);
            if (distance <= c1.radius + c2.radius)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
