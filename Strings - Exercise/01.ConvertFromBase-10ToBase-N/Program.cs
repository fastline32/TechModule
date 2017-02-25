using System;
using System.Linq;
using System.Numerics;

namespace _01.ConvertFromBase_10ToBase_N
{
    class Program
    {
        static void Main()
        {
            var inputLine = Console.ReadLine().Trim().Split(' ').ToArray();
            int baseToConvert = int.Parse(inputLine[0]);
            BigInteger num = BigInteger.Parse(inputLine[1]);
            string result = "";
            while (num > 0)
            {
                var resultNum = num % baseToConvert;
                result = resultNum + result;
                num /= baseToConvert;
            }
            Console.WriteLine(result);
        }
    }
}
