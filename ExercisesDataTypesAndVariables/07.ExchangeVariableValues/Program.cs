using System;

namespace _07.ExchangeVariableValues
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Before:");
            Console.WriteLine("a = {0}",num1);
            Console.WriteLine("b = {0}",num2);
            int num3 = num1;
            num1 = num2;
            num2 = num3;
            Console.WriteLine("After:");
            Console.WriteLine("a = {0}",num1);
            Console.WriteLine("b = {0}",num2);
        }
    }
}
