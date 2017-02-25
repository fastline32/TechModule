using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ExamPreparation
{
    public class Event
    {
        public Event(string name)
        {
            this.Name = name;
            this.Participants = new SortedSet<string>();
        }

        public string Name { get; private set; }

        public SortedSet<string> Participants { get; set; }

        public override string ToString()
        {
            StringBuilder output = new StringBuilder();

            output.AppendLine($"{this.Name} - {this.Participants.Count}");

            foreach (var participant in this.Participants)
            {
                output.AppendLine(participant);
            }

            return output.ToString().Trim();
        }
    }

    class Startup
    {
        static void Main()
        {
            Dictionary<string, Event> events = new Dictionary<string, Event>();
            string input = Console.ReadLine();

            while (input != "Time for Code")
            {
                string[] tokens = input.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                string id = tokens[0];
                string eventName = tokens[1];
                string clearedName = eventName.Substring(1);

                if (eventName.Contains("#"))
                {
                    if (!events.ContainsKey(id))
                    {
                        events.Add(id, new Event(clearedName));
                        AddNewParticipants(tokens, events, id);
                    }
                    else
                    {
                        if (events[id].Name == clearedName)
                        {
                            AddNewParticipants(tokens, events, id);
                        }
                    }
                }

                input = Console.ReadLine();
            }

            foreach (var @event in events.OrderByDescending(e => e.Value.Participants.Count).ThenBy(e => e.Value.Name))
            {
                Console.WriteLine(@event.Value);
            }
        }

        private static void AddNewParticipants(string[] tokens, Dictionary<string, Event> events, string id)
        {
            IEnumerable<string> participants = tokens.Skip(2);

            foreach (var participant in participants)
            {
                events[id].Participants.Add(participant);
            }
        }
    }
}