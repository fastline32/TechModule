using System;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

class RageQuit
{
    static void Main()
    {
        string userInput = Console.ReadLine();
        Regex pattern = new Regex(@"(\D+)(\d+)", RegexOptions.Compiled);
        StringBuilder output = new StringBuilder();
        MatchCollection matches = pattern.Matches(userInput);
        foreach (Match match in matches)
        {
            int repeats = int.Parse(match.Groups[2].Value);
            for (int i = 0; i < repeats; i++)
            {
                output.Append(match.Groups[1].Value.ToUpper());
            }
        }

        Console.WriteLine("Unique symbols used: {0}", output.ToString().Distinct().Count());
        Console.WriteLine(output.ToString());
    }
}