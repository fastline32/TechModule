using System;

namespace _05.DistanceOfTheStars
{
    class DistanceOfTheStars
    {
        static void Main()
        {
            decimal lightYear = 9450000000000;
            decimal distanceToErta = 4.22m * lightYear;
            decimal distanceToMilkWay = 26000m * lightYear;
            decimal diameterOfMilkWay = 100000m * lightYear;
            decimal distanceToTheEdge = 46500000000m * lightYear;

            Console.WriteLine(distanceToErta.ToString("e2"));
            Console.WriteLine(distanceToMilkWay.ToString("e2"));
            Console.WriteLine(diameterOfMilkWay.ToString("e2"));
            Console.WriteLine(distanceToTheEdge.ToString("e2"));
        }
    }
}
