using System;

namespace _07.GreaterOfTwoValues
{
    class GreaterOfTwoValues
    {
        static void Main()
        {
            string type = Console.ReadLine();
            switch (type)
            {
                case "int":
                    int num1 = int.Parse(Console.ReadLine());
                    int num2 = int.Parse(Console.ReadLine());
                    Console.WriteLine(GetMax(num1,num2));break;
                case "char":
                    char symbol1 = char.Parse(Console.ReadLine());
                    char symbol2 = char.Parse(Console.ReadLine());
                    Console.WriteLine(GetMax(symbol1,symbol2));break;
                case "string":
                    string line1 = Console.ReadLine();
                    string line2 = Console.ReadLine();
                    Console.WriteLine(GetMax(line1,line2));break;
            }
        }

        static int GetMax(int num1, int num2)
        {
            return Math.Max(num1, num2);
        }

        static char GetMax(char symbol1, char symbol2)
        {
            int num1 = (int) symbol1;
            int num2 = (int) symbol2;
            return (char)Math.Max(num1, num2);
        }

        static string GetMax(string line1, string line2)
        {
            if (line1.CompareTo(line2) >= 0)
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
