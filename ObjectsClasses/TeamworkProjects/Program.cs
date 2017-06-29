using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeamworkProjects
{
    class Team
    {
        public string TeamName { get; set; }
        public List<string> Members { get; set; }
        public  string CreatorName { get; set; }
    }

    class Program
    {
        static void Main()
        {

            List<Team> teams = new List<Team>();
            CreateTeams(teams);
            AddMembers(teams);
            PrintTeams(teams);
        }

        static void PrintTeams(List<Team> teams)
        {
            foreach (var squad in teams.OrderByDescending(t=>t.Members.Count).ThenBy(s=>s.TeamName))
            {
                if (squad.Members.Count > 1)
                {
                    Console.WriteLine($"{squad.TeamName}");
                    Console.WriteLine($"- {squad.CreatorName}");
                    Console.Write(string.Join("", squad.Members.Where(s => s != squad.CreatorName).OrderBy(s=>s).Select(s=>$"-- {s}" + Environment.NewLine)));
                }
            }
            Console.WriteLine("Teams to disband:");
            Console.Write(string.Join("", teams.Where(i => i.Members.Count < 2).OrderBy(s=>s.TeamName).Select(s => s.TeamName + Environment.NewLine)));
        }

        static void AddMembers(List<Team> teams)
        {
            while (true)
            {
                string[] currentMember = Console.ReadLine().Split(new char[] { '-', '>'}, StringSplitOptions.RemoveEmptyEntries).ToArray();
                string memberName = currentMember[0];
                if (memberName == "end of assignment")
                {
                    break;
                }

                string squadName = currentMember[1];
                if (!teams.Any(s=>s.TeamName == squadName))
                {
                    Console.WriteLine($"Team {squadName} does not exist!");
                    continue;
                }
                
                if (IsMember(teams, memberName))
                {
                    Console.WriteLine($"Member {memberName} cannot join team {squadName}!");
                }
                else
                {
                   foreach( var sq in teams.Where(s=>s.TeamName == squadName))
                    {
                        sq.Members.Add(memberName);
                        break;
                    }
                }
            }
        }

        static bool IsMember(List<Team> teams, string memberName)
        {
            foreach (var sqd in teams.Select(s => s.Members))
            {
                foreach (var mem in sqd)
                {
                    if (mem == memberName)
                    {
                        return true;
                    }
                }

            }

            return false;
        }

        static void CreateTeams(List<Team> teams)
        {
            int cycles = int.Parse(Console.ReadLine());

            for(int i=0; i<cycles; i++)
            {
                string[] currentCreator = Console.ReadLine().Split('-').ToArray();

                string currentTeamName = currentCreator[1];
                if (teams.Any(s=>s.TeamName == currentTeamName))
                {
                    Console.WriteLine($"Team {currentTeamName} was already created!");
                    continue;
                }

                string authorName = currentCreator[0];
                if (teams.Any(s=>s.CreatorName == authorName))
                {
                    Console.WriteLine($"{authorName} cannot create another team!");
                    continue;
                }

                Team currentTeam = new Team();
                currentTeam.TeamName = currentTeamName;
                currentTeam.Members = new List<string> { authorName };
                currentTeam.CreatorName = authorName;
                teams.Add(currentTeam);
                Console.WriteLine($"Team {currentTeamName} has been created by {authorName}!");
            }
        }
    }
}
