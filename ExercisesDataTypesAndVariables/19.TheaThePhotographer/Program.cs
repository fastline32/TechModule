using System;

namespace _19.TheaThePhotographer
{
    class Program
    {
        static void Main(string[] args)
        {
            long totalPhotos = long.Parse(Console.ReadLine());
            long filterTime = long.Parse(Console.ReadLine());
            long filterFactor = long.Parse(Console.ReadLine());
            long uploadTime = long.Parse(Console.ReadLine());

            decimal totalUsefulPhotos = Math.Ceiling((decimal)(totalPhotos * filterFactor) / 100);

            
            decimal totalTime = (totalPhotos * filterTime) + (totalUsefulPhotos * uploadTime);
            TimeSpan time = TimeSpan.FromSeconds((double)totalTime);
            string timeForPrint = time.ToString(@"d\:hh\:mm\:ss");
            Console.WriteLine(timeForPrint);
        }
    }
}
