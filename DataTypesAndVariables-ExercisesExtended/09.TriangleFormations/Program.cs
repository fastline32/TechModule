using System;

namespace _09.TriangleFormations
{
    class TriangleFormations
    {
        static void Main()
        {
            int sideA = int.Parse(Console.ReadLine());
            int sideB = int.Parse(Console.ReadLine());
            int sideC = int.Parse(Console.ReadLine());

            if (sideA + sideB > sideC && sideA + sideC > sideB && sideB + sideC > sideA)
            {
                Console.WriteLine("Triangle is valid.");
                if (sideA * sideA + sideB * sideB == sideC * sideC)
                {
                    Console.WriteLine("Triangle has a right angle between sides a and b");
                }
                else if (sideA * sideA + sideC * sideC == sideB * sideB)
                {
                    Console.WriteLine("Triangle has a right angle between sides a and c");
                }
                else if (sideB * sideB + sideC * sideC == sideA * sideA)
                {
                    Console.WriteLine("Triangle has a right angle between sides b and c");
                }
                else
                {
                    Console.WriteLine("Triangle has no right angles");
                }
            }
            else
            {
                Console.WriteLine("Invalid Triangle.");
            }
        }
    }
}
