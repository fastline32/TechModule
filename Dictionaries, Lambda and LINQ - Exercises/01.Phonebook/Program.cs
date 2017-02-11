using System;
using System.Collections.Generic;
using System.Linq;

namespace _01.Phonebook
{
    class Phonebook
    {
        static void Main()
        {
            var phonebook = new SortedDictionary<string , string>();
            string command = Console.ReadLine();
            while (command != "END")
            {
                List<string> items = command.Split(' ').ToList();

                string what = items[0];
                if (what == "A")
                {
                    if (phonebook.ContainsKey(items[1]))
                    {
                        phonebook[items[1]] = items[2];
                    }
                    else
                        phonebook.Add(items[1],items[2]);
                }

                else
                {
                    if (phonebook.ContainsKey(items[1]))
                    {
                        string phonenumber = "";
                        bool existValue = phonebook.TryGetValue(items[1], out phonenumber);
                        Console.WriteLine("{0} -> {1}",items[1] , phonenumber );
                    }
                    else
                    {
                        Console.WriteLine("Contact {0} does not exist.",items[1]);
                    }
                }
                command = Console.ReadLine();
            }
        }
    }
}
