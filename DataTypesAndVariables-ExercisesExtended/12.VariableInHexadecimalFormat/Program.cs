using System;

namespace _12.VariableInHexadecimalFormat
{
    class VariableInHexadecimalFormat
    {
        static void Main()
        {
            string number = Console.ReadLine();

            Console.WriteLine(Convert.ToInt32(number,16));
        }
    }
}
