using System;

namespace _07.GreaterOfTwoValues
{
    class Program
    {
        static void Main(string[] args)
        {
            string type = Console.ReadLine();
            if (type == "int")
            {
                int num1 = int.Parse(Console.ReadLine());
                int num2 = int.Parse(Console.ReadLine());
                int result = GetMax(num1, num2);
                Console.WriteLine(result);
            }
            else if (type == "char")
            {
                char a = char.Parse(Console.ReadLine());
                char b = char.Parse(Console.ReadLine());
                char result = GetMax(a, b);
                Console.WriteLine(result);
            }
            else
            {
                string line1 = Console.ReadLine();
                string line2 = Console.ReadLine();
                string result = GetMax(line1, line2);
                Console.WriteLine(result);
            }
        }

        static int GetMax(int num1, int num2)
        {
            if (num1 >= num2)
            {
                return num1;
            }
            else
            {
                return num2;
            }
        }

        static char GetMax(char a, char b)
        {
            if (a >= b)
            {
                return a;
            }
            else
            {
                return b;
            }
        }

        static string GetMax(string line1, string line2)
        {
            if (line1.CompareTo(line2)>=0)
            {
                return line1;
            }
            else
            {
                return line2;
            }
        }
    }
}
