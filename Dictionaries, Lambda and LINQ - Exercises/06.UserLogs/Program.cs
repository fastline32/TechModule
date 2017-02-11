using System;
using System.Collections.Generic;
using System.Linq;

namespace UserLogs
{
    class Program
    {
        static void Main(string[] args)
        {
            var dictionary = new SortedDictionary<string, Dictionary<string, int>>();
            // var address = new Dictionary<string, int>();
            var input = Console.ReadLine();
            var count = 1;
            while (input != "end")
            {
                var items = input.Split(' ', '=').ToArray();
                var username = items.Last();
                var ip = items[1];
                if (!dictionary.ContainsKey(username))
                {
                    dictionary[username] = new Dictionary<string, int>();
                }

                var address = dictionary[username];

                if (!address.ContainsKey(ip))
                {
                    address[ip] = count;
                }
                else
                {
                    address[ip] += count;
                }

                input = Console.ReadLine();
            }

            foreach (var users in dictionary)
            {
                Console.WriteLine($"{users.Key}: ");
                foreach (var addresses in users.Value)
                {
                    if (addresses.Equals(users.Value.Last()))
                    {
                        Console.WriteLine($"{addresses.Key} => {addresses.Value}.");
                        break;
                    }

                    Console.Write($"{addresses.Key} => {addresses.Value}, ");
                }
            }
        }
    }
}