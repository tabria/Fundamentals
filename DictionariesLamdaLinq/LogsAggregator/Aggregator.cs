using System;
using System.Collections.Generic;
using System.Linq;

namespace LogsAggregator
{
    class Aggregator
    {
        static void Main()
        {
            SortedDictionary<string, SortedDictionary<string, int>> userLog = new SortedDictionary<string, SortedDictionary<string, int>>();
            int cycles = int.Parse(Console.ReadLine());

            for(int i=0; i<cycles; i++)
            {
                string[] userInfo = Console.ReadLine().Split(' ').ToArray();
                var user = userInfo[1];
                var ip = userInfo[0];
                var sessionTime = int.Parse(userInfo[2]);

                if (!userLog.ContainsKey(user))
                {
                    userLog[user] = new SortedDictionary<string, int> { { ip, 0 } };
                }
                try
                {
                    userLog[user][ip] += sessionTime;
                }
                catch
                {
                    userLog[user][ip] = sessionTime;
                }

            }

            foreach (var kvp in userLog)
            {
                var currentUser = kvp.Key; 
                var sumSession = userLog[currentUser].Sum(a=>a.Value);

                 Console.WriteLine($"{currentUser}: {sumSession} [{string.Join(", ", userLog[currentUser].Keys)}]");
            }
        }
    }
}
