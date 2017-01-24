using System;

namespace _04.VariableInHexFormat
{
    class Program
    {
        static void Main(string[] args)
        {
            string textOne = Console.ReadLine();
            bool valueOne = Convert.ToBoolean(textOne);
            if (valueOne)
            {
                Console.WriteLine("Yes");
            }
            else
            {
                Console.WriteLine("No");
            }
        }
    }
}
