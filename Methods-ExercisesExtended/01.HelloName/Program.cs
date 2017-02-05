using System;

namespace _01.HelloName
{
    class HelloName
    {
        static void Main()
        {
            Console.WriteLine(Greeting());
        }

        static string Greeting()
        {
            string name = Console.ReadLine();
            string greeting = $"Hello, {name}!";
            return greeting;
        }
    }
}
