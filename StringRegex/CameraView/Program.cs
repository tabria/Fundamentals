using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace CameraView
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            string cameras = Console.ReadLine();

            int m = nums[0];
            int n = nums[1];

            string regex = $"(?<=\\|<.{{{m}}})[^|]{{0,{n}}}";

            //(?<=(?:\|<)(?:(?!\|<).){9})(?(?!\|<).){7}

            MatchCollection matches = Regex.Matches(cameras, regex);
            string[] results = matches.Cast<Match>().Select(s => s.Value).ToArray();

            Console.WriteLine(string.Join(", ", results));


        }
    }
}
