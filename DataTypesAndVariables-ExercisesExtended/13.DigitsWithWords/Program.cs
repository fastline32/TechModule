using System;

namespace _13.DigitsWithWords
{
    class DigitsWithWords
    {
        static void Main()
        {
            string line1 = Console.ReadLine().ToLower();
            switch (line1)
            {
                case "zero":
                    Console.WriteLine("0");break;
                case "one":
                    Console.WriteLine("1");break;
                case "two":
                    Console.WriteLine("2");break;
                case "three":
                    Console.WriteLine("3");break;
                case "four":
                    Console.WriteLine("4");break;
                case "five":
                    Console.WriteLine("5");break;
                case "six":
                    Console.WriteLine("6");break;
                case "seven":
                    Console.WriteLine("7");break;
                case "eight":
                    Console.WriteLine("8");break;
                case "nine":
                    Console.WriteLine("9");break;
            }
        }
    }
}
