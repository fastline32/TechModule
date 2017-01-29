using System;
using System.Linq;

namespace _05.RoundingNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] n = Console.ReadLine().Split(' ').Select(double.Parse).ToArray();
            foreach (double number in n)
            {
                Console.WriteLine("{0} => {1}", number, Math.Round(number, MidpointRounding.AwayFromZero));
            }
        }
    }
}
