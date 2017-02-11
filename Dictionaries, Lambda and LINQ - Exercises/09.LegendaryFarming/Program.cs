using System;
using System.Collections.Generic;
using System.Linq;

namespace _09.LegendaryFarming
{
    class Program
    {
        static void Main()
        {
            Dictionary<string, long> points = new Dictionary<string, long>();
            Dictionary<string, long> elementsJunk = new Dictionary<string, long>();
            Dictionary<string, long> elementsLegendary = new Dictionary<string, long>();
            points.Add("Shadowmourne", 0);
            points.Add("Valanyr", 0);
            points.Add("Dragonwrath", 0);
            elementsLegendary.Add("fragments", 0);
            elementsLegendary.Add("shards", 0);
            elementsLegendary.Add("motes", 0);
            while (true)
            {
                var input = Console.ReadLine().ToLower().Split(' ').ToArray();

                for (int i = 0; i < input.Length; i++)
                {

                    if (i % 2 != 0)
                    {
                        //Console.WriteLine(couple);

                        if (elementsLegendary.ContainsKey(input[i]))
                        {
                            elementsLegendary[input[i]] += int.Parse(input[i - 1]);
                        }
                        else
                        {
                            if (elementsJunk.ContainsKey(input[i]))
                            {
                                elementsJunk[input[i]] += int.Parse(input[i - 1]);
                            }
                            else
                            {
                                elementsJunk[input[i]] = int.Parse(input[i - 1]);
                            }
                        }

                        if (input[i] == "motes")
                        {
                            points["Dragonwrath"] += int.Parse(input[i - 1]);
                        }
                        else if (input[i] == "shards")
                        {
                            points["Shadowmourne"] += int.Parse(input[i - 1]);
                        }
                        else if (input[i] == "fragments")
                        {
                            points["Valanyr"] += int.Parse(input[i - 1]);
                        }

                    }

                    if (points["Valanyr"] >= 250)
                    {
                        elementsLegendary["fragments"] -= 250;
                        Console.WriteLine("Valanyr obtained!");

                        goto Output;
                    }
                    else if (points["Shadowmourne"] >= 250)
                    {
                        elementsLegendary["shards"] -= 250;
                        Console.WriteLine("Shadowmourne obtained!");

                        goto Output;
                    }
                    else if (points["Dragonwrath"] >= 250)
                    {
                        elementsLegendary["motes"] -= 250;
                        Console.WriteLine("Dragonwrath obtained!");
                        goto Output;
                    }

                }

            }


        Output:
            elementsLegendary = elementsLegendary.OrderByDescending(x => x.Value).ToDictionary(x => x.Key, x => x.Value);
            elementsJunk = elementsJunk.OrderByDescending(x => x.Value).ToDictionary(x => x.Key, x => x.Value);
            if (elementsLegendary.Values.Distinct().Count() != 3)
            {
                elementsLegendary = elementsLegendary.OrderBy(x => x.Key).ToDictionary(x => x.Key, x => x.Value);
            }
            if (elementsJunk.Values.Distinct().Count() != 3)
            {
                elementsJunk = elementsJunk.OrderBy(x => x.Key).ToDictionary(x => x.Key, x => x.Value);
            }
            foreach (KeyValuePair<string, long> pair in elementsLegendary.OrderByDescending(c => c.Value))
            {
                Console.WriteLine("{0}: {1}", pair.Key, pair.Value);
            }
            foreach (KeyValuePair<string, long> pair in elementsJunk.OrderBy(c => c.Key))
            {
                Console.WriteLine("{0}: {1}", pair.Key, pair.Value);
            }
        }
    }
}
