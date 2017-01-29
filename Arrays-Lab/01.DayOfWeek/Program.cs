using System;

namespace _01.DayOfWeek
{
    class Program
    {
        static void Main()
        {
            string[] day = { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday" };
            int n = int.Parse(Console.ReadLine());
            if (n >= 1 && n <= 7)
            {
                Console.WriteLine(day[n - 1]);
            }
            else
            {
                Console.WriteLine("Invalid day!");
            }
        }
    }
}
