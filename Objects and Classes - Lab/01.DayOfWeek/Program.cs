using System;
using System.Globalization;

namespace _01.DayOfWeek
{
    class Program
    {
        static void Main()
        {
            string dateAsText = Console.ReadLine();
            var date = DateTime.ParseExact(dateAsText, "d-M-yyyy", CultureInfo.InvariantCulture);
            Console.WriteLine(date.DayOfWeek);
        }
    }
}