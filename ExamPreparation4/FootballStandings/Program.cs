using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace FootballStandings
{

    class Team
    {
        public string Name { get; set; }
        public long Points { get; set; }
        public long Goal { get; set; }
    }

    class Program
    {
        static void Main()
        {
            string key = Regex.Escape(Console.ReadLine());
            var pattern = string.Format(@"^.*(?:{0})(?<teamA>[a-zA-z]*)(?:{0}).* .*(?:{0})(?<teamB>[a-zA-z]*)(?:{0}).* (?<teamAScore>\d+):(?<teamBScore>\d+).*$", key);
            Dictionary<string, Team> scoreBoard = new Dictionary<string, Team>();

            while (true)
            {
                string input = Console.ReadLine();

                if (input.Equals("final"))
                {
                    break;
                }

                var match = Regex.Match(input, pattern);
                var teamAName = new string (match.Groups["teamA"].Value.ToUpper().Reverse().ToArray());
                string teamBName = new string(match.Groups["teamB"].Value.ToUpper().Reverse().ToArray());
                long teamAGoals = long.Parse(match.Groups["teamAScore"].Value);
                long teamBGoals = long.Parse(match.Groups["teamBScore"].Value);
                long teamAPoints = 0;
                long teamBPoints = 0;
                if (teamAGoals == teamBGoals)
                {
                    teamAPoints = 1;
                    teamBPoints = 1;
                }
                else if (teamAGoals > teamBGoals)
                {
                    teamAPoints = 3;
                }
                else if (teamBGoals > teamAGoals)
                {
                    teamBPoints = 3;
                }

                TeamStatistic(scoreBoard, teamAName, teamAGoals, teamAPoints);
                TeamStatistic(scoreBoard, teamBName, teamBGoals, teamBPoints);

            }

            PrintScore(scoreBoard);

        }

        public static void PrintScore(Dictionary<string, Team> scoreBoard)
        {
            Console.WriteLine("League standings:");
            int i = 1;
            foreach (var team in scoreBoard.OrderByDescending(t=>t.Value.Points).ThenBy(t=>t.Key))
            {
                Console.WriteLine($"{i}. {team.Key} {team.Value.Points}");
                i++;
            }

            Console.WriteLine("Top 3 scored goals:");
            var bestGoals = scoreBoard.OrderByDescending(t => t.Value.Goal).ThenBy(t=>t.Key).Take(3).ToArray();
            foreach (var team in bestGoals)
            {
                Console.WriteLine($"- {team.Key} -> {team.Value.Goal}");
            }
        }

        public static void TeamStatistic(Dictionary<string, Team> scoreBoard, string teamName, long teamGoals, long teamPoints)
        {
            
            if (!scoreBoard.ContainsKey(teamName))
            {
                scoreBoard[teamName] = new Team();
                
            }
            scoreBoard[teamName].Goal += teamGoals;
            scoreBoard[teamName].Points += teamPoints;
        }
    }
}
