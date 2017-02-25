using System;
using System.Globalization;
using System.Numerics;

namespace _01.Sino_The_Walker
{
    class SinoTheWalker
    {
        static void Main()
        {
            DateTime leavingTime = DateTime.ParseExact(Console.ReadLine(), "HH:mm:ss", CultureInfo.InvariantCulture);
            int stpes = int.Parse(Console.ReadLine()) % 86400;
            int secondsPerStep = int.Parse(Console.ReadLine()) % 86400;

            BigInteger totalSecond = (BigInteger)stpes * secondsPerStep;
            DateTime finalTime = leavingTime.AddSeconds((double) totalSecond);

            Console.WriteLine("Time Arrival: {0}", finalTime.ToString("HH:mm:ss"));
        }

    }


}
