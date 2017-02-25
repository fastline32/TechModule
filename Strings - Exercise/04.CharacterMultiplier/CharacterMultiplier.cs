using System;

namespace _04.CharacterMultiplier
{
    class CharacterMultiplier
    {
        static void Main()
        {
            var inputLine = Console.ReadLine().Trim().Split(' ');
            string line1 = inputLine[0];
            string line2 = inputLine[1];

            Console.WriteLine(CharMultiplayer(line1,line2));
        }

        public static long CharMultiplayer(string line1, string line2)
        {
            long result = 0;
            if (line1.Length == line2.Length)
            {
                for (int i = 0; i < line1.Length; i++)
                {
                    result += line1[i] * line2[i];
                }
            }
            else if (line1.Length < line2.Length)
            {
                for (int i = 0; i < line1.Length; i++)
                {
                    result += line1[i] * line2[i];
                }
                for (int i = line1.Length; i < line2.Length; i++)
                {
                    result += line2[i];
                }
            }
            else if (line2.Length < line1.Length)
            {
                for (int i = 0; i < line2.Length; i++)
                {
                    result += line1[i] * line2[i];
                }
                for (int i = line2.Length; i < line1.Length; i++)
                {
                    result += line1[i];
                }
            }
           

            
            return result;
        }
    }
}
