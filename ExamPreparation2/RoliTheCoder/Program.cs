using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoliTheCoder
{

    class Event
    {
        public string EventName { get; set; }
        public List<string> Participants { get; set; }
    }

    class Program
    {
        static void Main()
        {
            Dictionary<string, Event> events = new Dictionary<string, Event>();

            while (true)
            {
                string[] request = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToArray();
                if (request[0] == "Time" && request[2] == "Code")
                {
                    break;
                }
                string eventName = request[1];
                if (eventName[0] != '#')
                {
                    continue;
                }
                string eventId = request[0];
                if (events.ContainsKey(eventId))
                {
                    if (events[eventId].EventName.Equals(eventName))
                    {
                        AddParticipants(events, request, eventId);
                    }
                }
                else
                {
                    events[eventId] = new Event()
                    {
                        EventName = eventName,
                        Participants = new List<string>()
                    };
                    AddParticipants(events, request, eventId);
                }
            }

            foreach (var occasion in events.OrderByDescending(s => s.Value.Participants.Count).ThenBy(s=>s.Value.EventName))
            {
                string occasionName = occasion.Value.EventName;
                Console.WriteLine($"{occasionName.Substring(1)} - {occasion.Value.Participants.Count}");
                foreach(var particip in occasion.Value.Participants.OrderBy(s => s))
                {
                    Console.WriteLine(particip);
                }
            }

        }

        static void AddParticipants(Dictionary<string, Event> events, string[] request, string eventId)
        {
            for (int i = 2; i < request.Length; i++)
            {
                if (events[eventId].Participants.Contains(request[i]))
                {
                    continue;
                }
                 events[eventId].Participants.Add(request[i]);
            }
        }
    }
}
