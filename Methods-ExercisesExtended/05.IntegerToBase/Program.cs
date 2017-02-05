using System;

namespace _05.IntegerToBase
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine(ConvertToBase());
        }

        static string ConvertToBase()
        {
            int num = int.Parse(Console.ReadLine());
            int baseToConvert = int.Parse(Console.ReadLine());
            string result = string.Empty;

            while (num > 0)
            {
                var reminder = num % baseToConvert;
                result = reminder + result;
                num /= baseToConvert;
            }
            return result;
        }
    }
}
