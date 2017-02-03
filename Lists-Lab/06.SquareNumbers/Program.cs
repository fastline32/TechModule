using System;
using System.Collections.Generic;
using System.Linq;

namespace _06.SquareNumbers
{
    class Program
    {
        static void Main()
        {
            List<double> spis = Console.ReadLine().Split(' ').Select(double.Parse).OrderByDescending(a => a).ToList();
            foreach (var item in spis)
            {
                var help = Math.Sqrt(item);
                if (help == (int)help)
                    Console.Write(item + " ");
            }
        }

    }
}
