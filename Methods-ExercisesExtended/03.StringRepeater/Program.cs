using System;

namespace _03.StringRepeater
{
    class StringRepeater
    {
        static void Main()
        {
            StringMaker();
        }

        static void StringMaker()
        {
            string line = Console.ReadLine();
            int count = int.Parse(Console.ReadLine());
            string printLine = "";
            for (int i = 0; i < count; i++)
            {
                printLine += line;
            }
            Console.WriteLine(printLine);
        }
    }
}
