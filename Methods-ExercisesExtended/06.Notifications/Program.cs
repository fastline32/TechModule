using System;

namespace _06.Notifications
{
    class Notifications
    {
        static void Main()
        {
            int commandCount = int.Parse(Console.ReadLine());
            for (int i = 0; i < commandCount; i++)
            {
                string command = Console.ReadLine();
                switch (command)
                {
                    case "success":ShowSuccess();break;
                    case "error":ShowError();break;
                    default:
                        command = Console.ReadLine();break;
                }
            }
        }

        static void ShowError()
        {
            string operation = Console.ReadLine();
            int code = int.Parse(Console.ReadLine());
            Console.WriteLine($"Error: Failed to execute {operation}.");
            Console.WriteLine(new string('=',30));
            Console.WriteLine($"Error Code: {code}.");
            if (code > 0)
            {
                Console.WriteLine("Reason: Invalid Client Data.");
            }
            else
            {
                Console.WriteLine("Reason: Internal System Failure.");
            }
            return;
        }

        static void ShowSuccess()
        {
            string operation = Console.ReadLine();
            string message = Console.ReadLine();
            Console.WriteLine($"Successfully executed {operation}.");
            Console.WriteLine(new string('=', 30));
            Console.WriteLine($"Message: {message}.");
            return;
        }
    }
}
