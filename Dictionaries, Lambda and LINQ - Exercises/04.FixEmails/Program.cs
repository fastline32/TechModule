using System;
using System.Collections.Generic;

namespace _08.FixEmails
{
    class FixEmails
    {
        static void Main()
        {
            List<string> email = new List<string>();
            List<string> names = new List<string>();
            Dictionary<string, string> nameAndEmails = new Dictionary<string, string>();
            string nameOfPerson = Console.ReadLine();
            string emails = string.Empty; ;

            while (nameOfPerson != "stop")
            {
                emails = Console.ReadLine();
                if (nameOfPerson != "stop" && emails != "stop")
                {
                    nameAndEmails.Add(nameOfPerson, emails);
                }
                else
                {
                    break;
                }
                nameOfPerson = Console.ReadLine();
            }
            Console.WriteLine();

            foreach (var name in nameAndEmails.Keys)
            {
                foreach (var mail in nameAndEmails.Values)
                {
                    if (/*(!mail.Contains("us") && !mail.Contains("uk")) &&*/ /*(!mail.Contains("US") && !mail.Contains("UK") &&*/
                        !email.Contains(mail) && !names.Contains(name))
                    {
                        Console.WriteLine("{0} -> {1}", name, mail);
                        email.Add(mail);
                        names.Add(name);
                    }
                }
            }
        }
    }
}