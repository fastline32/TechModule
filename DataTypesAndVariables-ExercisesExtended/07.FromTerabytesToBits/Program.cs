using System;

namespace _07.FromTerabytesToBits
{
    class FromTerabytesToBits
    {
        static void Main()
        {
            decimal terabit = decimal.Parse(Console.ReadLine());
            decimal byteResult = terabit * (1024m * 1024 * 1024 * 1024 * 8);
            Console.WriteLine("{0:f0}", byteResult);
        }
    }
}
