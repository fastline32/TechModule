using System;

namespace _11.ConvertSpeedUnits
{
    class Program
    {
        static void Main(string[] args)
        {
            int distanceInMeters = int.Parse(Console.ReadLine());
            int hours = int.Parse(Console.ReadLine());
            int minutes = int.Parse(Console.ReadLine());
            int seconds = int.Parse(Console.ReadLine());
            float hourTime = hours + minutes / 60.0f + seconds / 3600.0f;
            float kmSpeed = (distanceInMeters / 1000.0f) / hourTime;
            float metersSpeed = kmSpeed / 3.6f;
            float milesSpeed = (distanceInMeters / 1609.0f) / hourTime;

            Console.WriteLine("{0}", metersSpeed);
            Console.WriteLine("{0}", kmSpeed);
            Console.WriteLine("{0}", milesSpeed);
        }
    }
}
