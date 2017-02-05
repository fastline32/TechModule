using System;

namespace _7.Cypher_Roulette
{
    public class Program
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            Console.WriteLine(ConcatenateText(n));
        }

        public static string ConcatenateText(int number)
        {
            string concatinatedText = null;
            string command = null;
            string repetedText = null;

            for (int i = 0; i < number; i++)
            {
                string text = Console.ReadLine();

                if (repetedText != text)
                {
                    if (command == "spin")
                    {
                        if (text == "spin")
                        {
                            i--;
                            command = null;
                        }
                        else
                        {
                            concatinatedText = text + concatinatedText;
                        }

                    }
                    else if (text == "spin")
                    {
                        i--;
                        command = "spin";
                    }
                    else
                    {
                        concatinatedText += text;
                    }
                    repetedText = text;

                }
                else
                {
                    if (text == "spin")
                    {
                        i--;
                        command = null;
                        repetedText = null;
                    }

                    concatinatedText = null;

                }

            }
            return concatinatedText;
        }
    }
}