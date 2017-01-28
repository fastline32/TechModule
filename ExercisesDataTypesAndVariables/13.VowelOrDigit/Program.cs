using System;

namespace _13.VowelOrDigit
{
    class Program
    {
        static void Main(string[] args)
        {
            char item = char.Parse(Console.ReadLine());
            if (item == 'a' || item == 'e' || item == 'i' || item == 'o' || item == 'u')
            {
                Console.WriteLine("vowel");
            }
            else if ((item >= '0') && (item <='9'))
            {
                Console.WriteLine("digit");
            }
            else
            {
                Console.WriteLine("other");
            }
        }
    }
}
