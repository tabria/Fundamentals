using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace EmailStatistics
{
    class Program
    {
        static void Main()
        {

            int cycles = int.Parse(Console.ReadLine());
            string regex = "^(?<user>[A-Za-z]{5,})@(?<mail>[a-z]{3,}(.com|.bg|.org))$";
            Dictionary<string, List<string>> userInfo = new Dictionary<string, List<string>>();

            for (int i =0; i<cycles; i++)
            {

                string currentEmail = Console.ReadLine();
                string user = Regex.Match(currentEmail, regex).Groups["user"].Value;
                string email = Regex.Match(currentEmail, regex).Groups["mail"].Value;
                if (string.IsNullOrEmpty(user) || string.IsNullOrEmpty(email))
                {
                    continue;
                }
                if (!userInfo.ContainsKey(email))
                {
                    userInfo[email] = new List<string>();
                }
                if (!userInfo[email].Contains(user))
                {
                    userInfo[email].Add(user);
                }
            }

            foreach(var mail in userInfo.OrderByDescending(s => s.Value.Count()))
            {
                Console.WriteLine($"{mail.Key}:");
                foreach(var user in mail.Value)
                {
                    Console.WriteLine($"### {user}");
                }
            }
        }
    }
}
