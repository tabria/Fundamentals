using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftUniKaraoke
{
    class karaoke
    {
        static void Main()
        {

            string[] participants = Console.ReadLine().Split(',').Select(s => s.Trim()).ToArray();
            string[] songList = Console.ReadLine().Split(',').Select(s => s.Trim()).ToArray();
            Dictionary<string, List<string>> participantsAwards = new Dictionary<string, List<string>>();

            while (true)
            {
                string[] currentPerformance = Console.ReadLine().Split(',').Select(s => s.Trim()).ToArray();
                if (currentPerformance[0] == "dawn")
                {
                    break;
                }
                AddParticipantsAwards(currentPerformance, participantsAwards, participants, songList);
            }
            PrintAwards(participantsAwards);
        }

        public static void AddParticipantsAwards(string[] currentPerformance, Dictionary<string, List<string>> participantsAwards, string[] participants, string[] songList)
        {
            string performer = currentPerformance[0];
            string currentSong = currentPerformance[1];
            string currentAward = currentPerformance[2];
            if (participants.Contains(performer) && songList.Contains(currentSong))
            {
                if (!participantsAwards.ContainsKey(performer))
                {
                    participantsAwards[performer] = new List<string>();
                }
                else if (participantsAwards[performer].Contains(currentAward))
                {
                    return;
                }
                participantsAwards[performer].Add(currentAward);
            }
        }

        public static void PrintAwards(Dictionary<string, List<string>> participantsAwards)
        {
            if (participantsAwards.Count != 0)
            {
                PrintParticipantAwards(participantsAwards);
            }
            else
            {
                Console.WriteLine("No awards");
            }
        }

        public static void PrintParticipantAwards(Dictionary<string, List<string>> participantsAwards)
        {
            foreach (var singer in participantsAwards.OrderByDescending(s => s.Value.Count()))
            {
                Console.WriteLine($"{singer.Key}: {singer.Value.Count} awards");
                foreach (var user in singer.Value.OrderBy(s => s))
                {
                    Console.WriteLine($"--{user}");
                }
            }
        }
    }
}
