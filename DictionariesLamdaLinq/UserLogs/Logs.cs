using System;
using System.Collections.Generic;
using System.Linq;

namespace UserLogs
{
    class Logs
    {
        static void Main()
        {
            SortedDictionary<string, Dictionary<string, int>> userIpLog = new SortedDictionary<string, Dictionary<string, int>>();

            while (true)
            {

                string[] userInfo = Console.ReadLine().Split(' ').ToArray();
                if (userInfo[0] == "end")
                {
                    break;
                }

                var username = userInfo[2].Substring(5);
                var ip = userInfo[0].Substring(3);

                if (!userIpLog.ContainsKey(username))
                {
                    userIpLog[username] = new Dictionary<string, int> { { ip, 1 } };
                }
                else
                {
                    if (userIpLog[username].ContainsKey(ip))
                    {
                        userIpLog[username][ip]++;
                    }
                    else
                    {
                        userIpLog[username][ip] = 1;
                    }
                }

            }

            foreach(var user in userIpLog)
            {
                Console.WriteLine($"{user.Key}: ");

                var userIps = user.Value;
                foreach (var ip in userIps)
                {
                    string ipSplit = ip.Equals(userIps.Last()) ? "." + Environment.NewLine : ", ";       
                    Console.Write($"{ip.Key} => {ip.Value}{ipSplit}");
                }
            }
        }
    }
}
           