using System;
using System.Collections.Generic;

namespace _05.User_Logins
{
    class UserLogins
    {
        static void Main()
        {
            string inputLine = Console.ReadLine();
            Dictionary<string,string> result = new Dictionary<string, string>();
            while (inputLine != "login")
            {
                var tokens = inputLine.Split();
                var username = tokens[0];
                var password = tokens[tokens.Length - 1];
                result[username] = password;
                inputLine = Console.ReadLine();
            }
            inputLine = Console.ReadLine();
            int count = 0;
            while (inputLine != "end")
            {
                var tokens = inputLine.Split();
                var username = tokens[0];
                var password = tokens[tokens.Length - 1];
                
                if (!result.ContainsKey(username))
                {
                    Console.WriteLine($"{username}: login failed");
                    count++;
                }
                else
                {
                    string match = result[username];
                    if (match != password)
                    {
                        Console.WriteLine($"{username}: login failed");
                        count++;
                    }
                    else
                    {
                        Console.WriteLine($"{username}: logged in successfully");
                    }
                }
                inputLine = Console.ReadLine();
            }
            Console.WriteLine($"unsuccessful login attempts: {count}");
        }
    }
}
