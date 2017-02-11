using System;
using System.Collections.Generic;
using System.Linq;

namespace _07.PopulationCounter
{
    class Program
    {
        static void Main()
        {
            Dictionary<string, Dictionary<string, long>> countries = new Dictionary<string, Dictionary<string, long>>();

            while (true)
            {
                string[] input = Console.ReadLine().Split(new char[] {'|'});

                if (input[0] == "report")
                    break;

                string town = input[0];
                string country = input[1];
                int population = int.Parse(input[2]);

                if (!countries.ContainsKey(country))
                {
                    countries.Add(country, new Dictionary<string, long>());
                }

                countries[country].Add(town, population);
            }
            var sortedCountries =
                countries.OrderByDescending(x => x.Value.Values.Sum());

            foreach (var country in sortedCountries)
            {
                Console.Write("{0} ", country.Key);
                Console.WriteLine("(total population: {0})", country.Value.Values.Sum());

                var sortedTowns = from entry in country.Value orderby entry.Value descending select entry;

                foreach (var town in sortedTowns)
                {
                    Console.WriteLine("=>{0}: {1}", town.Key, town.Value);
                }
            }
        }
    }
}
