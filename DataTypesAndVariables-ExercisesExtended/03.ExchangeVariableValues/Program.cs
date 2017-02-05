using System;

namespace _03.ExchangeVariableValues
{
    class Program
    {
        static void Main()
        {
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            int num3 = num1;
            num1 = num2;
            num2 = num3;
            Console.WriteLine(num1);
            Console.WriteLine(num2);
        }
    }
}
