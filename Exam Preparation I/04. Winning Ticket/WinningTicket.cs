using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace _04.Winning_Ticket
{
    public class WinningTicket
    {
        public static void Main()
        {
            var tickets = Console.ReadLine()
                .Split(new[] { ',' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(t => t.Trim())
                .ToArray();
            
            foreach (var ticket in tickets)
            {
                var winningTicket = false;
                if (ticket.Length != 20)
                {
                    Console.WriteLine("invalid ticket");
                    continue;
                }

                var left = new string(ticket.Take(10).ToArray());
                var right = new string(ticket.Skip(10).ToArray());

                var winningSymbols = new string[] { "@", "#", "\\$", "\\^" };

                foreach (var winningSymbol in winningSymbols)
                {
                    var regex = new Regex($"{winningSymbol}{{6,}}");
                    var leftMatch = regex.Match(left);

                    if (leftMatch.Success) // regex.IsMatch(left)
                    {
                        var rigthMatch = regex.Match(right);

                        if (rigthMatch.Success)
                        {
                            winningTicket = true;

                            var leftsymbolsLength = leftMatch.Value.Length;
                            var rightsymbolsLength = rigthMatch.Value.Length;

                            var jackpot = leftsymbolsLength == 10 && rightsymbolsLength == 10
                                ? "Jackpot!"
                                : string.Empty;

                            Console.WriteLine($"ticket \"{ticket}\" - {Math.Min(leftsymbolsLength, rightsymbolsLength)}{winningSymbol.Trim('\\')} {jackpot}");

                            break;
                        }
                    }
                }
                if (!winningTicket)
                {
                    Console.WriteLine($"ticket \"{ticket}\" - no match");
                }
            }
        }
    }
}