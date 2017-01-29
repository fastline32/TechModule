using System;

namespace _04.NumbersInReversedOrder
{
    class Program
    {
        static void Main()
        {
            string number = Console.ReadLine();
            GetLastDigit(number);
        }
        private static void GetLastDigit(string number)
        {
            int a = 1;
            string result = "";
            for (int i = number.Length; i > 0; i--)
            {
                char digit = number[number.Length - a];
                result = result + digit;
                a++;
            }
            Console.WriteLine(result);
        }
    }
}
