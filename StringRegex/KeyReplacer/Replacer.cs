using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace KeyReplacer
{
    class Replacer
    {
        static void Main()
        {
            string key = Console.ReadLine();
            string text = Console.ReadLine();

            string startKeyRegex = @"^[A-z]*?(?=[<|\\])";
            string endKeyRegex = @"(?!.*[\\|<])[A-z]*$";
            
            string startKey = Regex.Match(key, startKeyRegex).Value;
            string endKey = Regex.Match(key, endKeyRegex).Value;

            string textRegex = $"(?<={startKey})(.*?)(?={endKey})";
                //$"(?<={startKey})((?:(?!{endKey}).)*)";

            MatchCollection result = Regex.Matches(text, textRegex);

            StringBuilder sb = new StringBuilder();

            foreach(Match match in result)
            {
                sb.Append(match.Value);
            }

            string res = sb.ToString();
            if (string.IsNullOrEmpty(res))
            {
                Console.WriteLine("Empty result");
            }
            else
            {
                Console.WriteLine(res);
            }
            


        }
    }
}
