using System;

namespace _1.HelloName
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            PrintGreeteng(name);
        }

        static void PrintGreeteng(string line)
        {
            Console.WriteLine("Hello, {0}!",line);
        }
    }
}
