using System;
using System.IO;

namespace _01.OddLines
{
    class Program
    {
        static void Main()
        {
            File.WriteAllText("output.txt", "");
            File.WriteAllText("input.txt", "Two households, both alike in dignity,\n" +
                                           "In fair Verona, where we lay our scene,\n" +
                                           "From ancient grudge break to new mutiny,\n" +
                                           "Where civil blood makes civil hands unclean.\n" +
                                           "From forth the fatal loins of these two foes\n" +
                                           "A pair of star-cross'd lovers take their life;\n" +
                                           "Whose misadventured piteous overthrows\n" +
                                           "Do with their death bury their parents' strife.\n");
            string[] text = File.ReadAllLines("input.txt");

            for (int i = 1; i < text.Length; i += 2)
            {
                Console.WriteLine(text[i]);
                File.AppendAllText("output.txt", text[i] + Environment.NewLine);
            }
        }
    }
}
