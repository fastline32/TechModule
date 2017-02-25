namespace CharityMarathon
{
    using System;

    public class Start
    {
        public static void Main()
        {
            long days = long.Parse(Console.ReadLine());
            long runnersCount = long.Parse(Console.ReadLine());
            int lapsPerRunner = int.Parse(Console.ReadLine());
            long trackLenght = long.Parse(Console.ReadLine());
            long trackCapacity = long.Parse(Console.ReadLine());
            decimal moneyPerKm = decimal.Parse(Console.ReadLine());

            long maxRunners = trackCapacity * days;
            long willRun = Math.Min(maxRunners, runnersCount);
            long totalKm = (willRun * lapsPerRunner * trackLenght) / 1000;
            decimal risedMoney = moneyPerKm * totalKm;

            Console.WriteLine($"Money raised: {risedMoney:f2}");
        }
    }
}