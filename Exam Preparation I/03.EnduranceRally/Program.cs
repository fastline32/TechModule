using System;
using System.Collections.Generic;
using System.Linq;

namespace _03.EnduranceRally
{
    class Program
    {
        static void Main()
        {
            List<string> inputDrivers = Console.ReadLine().Split(new char[] { ' ' }
                                    , StringSplitOptions
                                    .RemoveEmptyEntries)
                                    .ToList();
            List<double> zone = Console.ReadLine().Split(new char[] { ' ' }
                                    , StringSplitOptions
                                    .RemoveEmptyEntries)
                                    .Select(double.Parse)
                                    .ToList();
            List<long> index = Console.ReadLine().Split(new char[] { ' ' }
                                    , StringSplitOptions
                                    .RemoveEmptyEntries)
                                    .Select(long.Parse)
                                    .ToList();


            foreach (var nameDriver in inputDrivers)
            {

                double fuel = nameDriver[0];

                for (int i = 0; i < zone.Count; i++)
                {
                    bool openZone = false;

                    if (index.Contains(i))
                    {
                        fuel += zone[i];
                        openZone = true;
                    }

                    if (openZone == false)
                    {
                        fuel -= zone[i];
                    }
                    if (fuel <= 0)
                    {
                        Console.WriteLine("{0} - reached {1}", nameDriver, i);
                        goto startLine;
                    }
                }
                Console.WriteLine("{0} - fuel left {1:f2}", nameDriver, fuel);
            startLine:
                ;
            }
        }
    }
}