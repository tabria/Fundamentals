using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace EmailMe
{
    class Email
    {
        static void Main()
        {
            string email = Console.ReadLine();
            string regex = @"(.+)@(.+)";

            Match match = Regex.Match(email, regex);
            int sumBeforeAt = match.Groups[1].Value.Sum(ch => ch);
            int sumAfterAt = match.Groups[2].Value.Sum(ch => ch);

            if (sumAfterAt - sumBeforeAt > 0)
            {
                Console.WriteLine("She is not the one.");
            }
            else
            {
                Console.WriteLine("Call her!");
            }

        }
    }
}
