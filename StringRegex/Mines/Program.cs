using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Mines
{
    class Program
    {
        static void Main()
        {

            string strMine = Console.ReadLine();
            string regex = @"(<.{2}>)";
            
            var arrs = Regex.Matches(strMine, regex).Cast<Match>().Select(m => m.Value).ToArray();
            for(int i =0; i < arrs.Length; i++)
            {
                int index = strMine.IndexOf(arrs[i]);
                int removeValue = Math.Abs(arrs[i][1] - arrs[i][2]);
                int removeLeft = index - removeValue < 0 ? index : removeValue;
                int removeRight = index + 3 + removeValue > strMine.Length - 1 ? strMine.Length - index - 4 : removeValue;
                string regexReplace = $".{{{removeLeft}}}{arrs[i]}.{{{removeRight}}}";
                strMine = Regex.Replace(strMine, regexReplace, new string('_', removeLeft+removeRight + 4));
            }
            Console.WriteLine(strMine);
        }
    }
}
