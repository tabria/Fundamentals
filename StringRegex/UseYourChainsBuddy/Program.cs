using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace UseYourChainsBuddy
{
    class Program
    {
        static void Main()
        {
            string inputText = Console.ReadLine();
            string regex = @"(<p>(.*?)<\/p>)";
            string replace = @"([^a-z0-9])";

            StringBuilder sb = new StringBuilder();
            MatchCollection pMatches = Regex.Matches(inputText, regex);

            string decrypt = string.Empty;
            foreach(Match match in pMatches)
            {
                decrypt += match.Groups[2].ToString();
            }

            decrypt = Regex.Replace(decrypt, replace, " ");
            decrypt = Regex.Replace(decrypt, @"\s+|\n+", " ");

            for (int i = 0; i < decrypt.Length; i++)
            {
                char replacedChar = decrypt[i];
                if (char.IsLetter(replacedChar))
                {
                    replacedChar = replacedChar <= 'm' ? (char)(replacedChar + 13) : (char)(replacedChar - 13);
                }

                sb.Append(replacedChar);
            }
            Console.WriteLine(sb.ToString());

        }
    }
}
