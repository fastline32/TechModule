using System;

namespace _9.ReverseCharacters
{
    class Program
    {
        static void Main(string[] args)
        {
            char char1 = char.Parse(Console.ReadLine());
            char char2 = char.Parse(Console.ReadLine());
            char char3 = char.Parse(Console.ReadLine());

            Console.WriteLine("{0}{1}{2}", char3, char2, char1);
        }
    }
}
