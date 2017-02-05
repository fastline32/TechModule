using System;
using System.Globalization;

namespace _08.TravelingAtLightSpeed
{
    class TravelingAtLightSpeed
    {
        static void Main()
        {
            decimal lightYear = 9450000000000m;
            decimal lightSpeed = 300000m;
            decimal years = decimal.Parse(Console.ReadLine());

            decimal totalTime = (lightYear / lightSpeed) * years;

            TimeSpan total = TimeSpan.FromSeconds((double) totalTime);
            string forPrint = string.Format(CultureInfo.CurrentCulture,
                "{0} weeks\n{1} days\n{2} hours\n{3} minutes\n{4} seconds",
                total.Days / 7,
                total.Days % 7,
                total.Hours,
                total.Minutes,
                total.Seconds);
            Console.WriteLine(forPrint);
        }
    }
}
