using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace MatchPhoneNumber
{
    class Program
    {
        static void Main()
        {


            string regex = @" ?\+359([ -])2\1\d{3}\1\d{4}\b";
            string phones = Console.ReadLine();

            MatchCollection validPhones = Regex.Matches(phones, regex);

            string[] phoneNumbers = validPhones.Cast<Match>().Select(s => s.Value.Trim()).ToArray();
            Console.WriteLine(string.Join(", ", phoneNumbers));


            //foreach (Match phoneNumbers in validPhones)
            //{
            //    Console.WriteLine(phoneNumbers.Value);
            //}
            //Console.WriteLine();
        }
    }
}
