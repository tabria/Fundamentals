using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ValidUsernames
{
    class UsernameValidate
    {
        static void Main()
        {

            string textUsernames = Console.ReadLine();
            string regex = @"(?<=[\s\/\\()]|\b)[A-Za-z][\w\d]{2,24}\b";

            MatchCollection users = Regex.Matches(textUsernames, regex);
            var castUsers = users.Cast<Match>().Select(s => s.Value).ToArray();
   
            string[] longestUsernames = new string[2];
            int sum = 0;

            for (int i = 0; i < castUsers.Length-1; i ++)
            {
                int currentSum = 0;
                currentSum = castUsers[i].Length + castUsers[i + 1].Length;
                if (currentSum > sum)
                {
                    sum = currentSum;
                    longestUsernames[0] = castUsers[i];
                    longestUsernames[1] = castUsers[i + 1];
                }
            }

            Console.Write(string.Join(Environment.NewLine, longestUsernames));
            Console.WriteLine();
        }
    }
}
