using System;
using System.Collections.Generic;
using System.Linq;

namespace FixEmails
{
    class Emails
    {
        static void Main()
        {
            Dictionary<string, string> personEmails = new Dictionary<string, string>();

            string personName = string.Empty;
            while (true)
            {
                string personInfo = Console.ReadLine();
                if (personInfo == "stop")
                {
                    break;
                }

                if (string.IsNullOrEmpty(personName))
                {
                    personName = personInfo;
                }
                else
                {
                    var takeEmailDomain = personInfo.Skip(personInfo.Length - 3).Take(3).ToArray();
                    var extention = new string(takeEmailDomain);
                    if (extention != ".uk" && extention != ".us")
                    {
                        personEmails[personName] = personInfo;
                    }

                    personName = string.Empty;
                }
            }

            Console.WriteLine(string.Join("", personEmails.Select(x => x.Key + " -> " + x.Value + Environment.NewLine)));
        }
    }
}
