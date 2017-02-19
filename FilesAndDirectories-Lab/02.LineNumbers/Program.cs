using System.Collections.Generic;
using System.IO;

namespace _02.LineNumbers
{
    class Program
    {
        static void Main()
        {
            string[] text = File.ReadAllLines("input.txt");

            List<string> result = new List<string>();

            for (int i = 0; i < text.Length; i++)
            {
                result.Add($"{i + 1}. {text[i]}");
            }

            File.WriteAllLines("output.txt", result);
        }
    }
}
