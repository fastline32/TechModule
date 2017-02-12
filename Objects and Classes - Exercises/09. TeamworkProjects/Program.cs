using System;
using System.Collections.Generic;
using System.Linq;

namespace _09.TeamworkProjects
{
    public class TeamsAndMembers
    {
        public static void Main()
        {
            var teams = new List<Team>();

            var n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                var tokens = Console.ReadLine()
                    .Split('-');

                var creator = tokens[0];
                var teamName = tokens[1];

                var currentTeam = new Team();
                currentTeam.Name = teamName;
                currentTeam.Members = new List<string>();
                currentTeam.CreatorName = creator;

                if (teams.Any(t => t.Name == teamName))
                {
                    Console.WriteLine($"Team {teamName} was already created!");
                }
                else if (teams.Any(g => g.CreatorName == creator))
                {
                    Console.WriteLine($"{creator} cannot create another team!");
                }
                else
                {
                    Console.WriteLine($"Team {teamName} has been created by {creator}!");
                    teams.Add(currentTeam);
                }
            }

            var line = Console.ReadLine();

            while (line != "end of assignment")
            {
                var assignmentTokens = line
                    .Split("->".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);

                var nameOfStudent = assignmentTokens[0];
                var teamToAssign = assignmentTokens[1];

                var first = teams.FirstOrDefault(m => m.CreatorName == nameOfStudent);

                if (teams.All(k => k.Name != teamToAssign))
                {
                    Console.WriteLine($"Team {teamToAssign} does not exist!");
                }
                else if (teams.Any(v => v.Members.Contains(nameOfStudent))
                         || teams.Any(k => k.CreatorName == nameOfStudent))
                {
                    Console.WriteLine($"Member {nameOfStudent} cannot join team {teamToAssign}!");
                }
                else
                {
                    teams.First(d => d.Name == teamToAssign).Members.Add(nameOfStudent);
                }


                line = Console.ReadLine();
            }

            var teamsWhitMembes = teams
                .Where(m => m.Members.Count > 0)
                .ToList();
            var teamsWhitNoMembers = teams
                .Where(s => s.Members.Count == 0)
                .ToList();
            
            foreach (var team in teamsWhitMembes.OrderByDescending(m => m.Members.Count).ThenBy(t => t.Name))
            {
                Console.WriteLine(team.Name);
                Console.WriteLine("- " + team.CreatorName);
                foreach (var member in team.Members.OrderBy(o => o).ToList())
                {
                    Console.WriteLine("-- " + member);
                }
            }
            Console.WriteLine("Teams to disband:");
            foreach (var team in teamsWhitNoMembers.OrderBy(m => m.Name))
            {
                Console.WriteLine(team.Name);
            }
        }
    }

    class Team
    {
        public string Name { get; set; }
        public List<string> Members { get; set; }
        public string CreatorName { get; set; }
    }
}