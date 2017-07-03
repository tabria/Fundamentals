using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace QueryMess
{
    class Mess
    {
        static void Main()
        {

            string mainPattern = @"([^&=?]*)=([^&=]*)";
            string regex = @"((%20|\+)+)";
            Dictionary<string, string> result = new Dictionary<string, string>();

            while (true)
            {
                string inputText = Console.ReadLine();
                if (inputText == "END")
                {
                    break;
                }

                MatchCollection currentMatch = Regex.Matches(inputText, mainPattern);
                foreach(Match match in currentMatch)
                {
                    var matchKey = match.Groups[1].Value;
                    var matchValue = match.Groups[2].Value;

                    matchKey = Regex.Replace(matchKey, regex, " ").Trim();
                    matchValue = Regex.Replace(matchValue, regex, " ").Trim();
                   try
                    {
                        var valueDict = result[matchKey];

                        result[matchKey] = valueDict + ", " + matchValue;
                        
                    }
                    catch
                    {
                        result[matchKey] = matchValue;
                    }

                }
                foreach (var pair in result)
                {
                    Console.Write($"{pair.Key}=[{pair.Value}]");
                }
                Console.WriteLine();
                result.Clear();
            }
           
        }
    }
}
