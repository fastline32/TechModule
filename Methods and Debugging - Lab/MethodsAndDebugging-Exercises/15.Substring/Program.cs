using System;

public class Substring_broken
{
    public static void Main()
    {
        var text = Console.ReadLine();
        int jump = int.Parse(Console.ReadLine());
        
        bool hasMatch = false;

        for (int i = 0; i < text.Length; i++)
        {
            if (text[i] == 'p')
            {
                hasMatch = true;

                int endIndex = jump+1;

                if (endIndex + i > text.Length)
                {
                    endIndex = text.Length-i;
                }

                string matchedString = text.Substring(i, endIndex);
                Console.WriteLine(matchedString);
                i += jump-1;
            }
        }

        if (!hasMatch)
        {
            Console.WriteLine("no");
        }
    }
}
