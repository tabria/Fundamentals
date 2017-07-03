using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ReplaceTag
{
    class TagReplace
    {
        static void Main()
        {
            while (true)
            {
                string currentString = Console.ReadLine();
                if (currentString == "end")
                {
                    break;
                }

                string regex = @"<a.*?href.*?=(.*)>(.*?)<\/a>";
                string replace = @"[URL href=$1]$2[/URL]";
                string replaced = Regex.Replace(currentString, regex, replace);
                Console.WriteLine(replaced);

            }


        }
    }
}
