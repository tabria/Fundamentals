using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace CubicsMessages
{
    class Program
    {
        static void Main()
        {
            while (true)
            {
                var encryptMessage = Console.ReadLine();
                if (encryptMessage.Equals("Over!"))
                {
                    break;
                }
                int messageLenght = int.Parse(Console.ReadLine());
                Regex messageRegex = new Regex(string.Format(@"^(?<digitsLeft>\d+)(?<message>[a-zA-Z]{{{0}}})([^a-zA-Z])*$", messageLenght));
                var match = messageRegex.Match(encryptMessage);
                if (!match.Success)
                {
                    continue;
                }
                string message = match.Groups["message"].Value;
                var allDigits = Regex.Replace(encryptMessage, @"[^\d]", "");
                StringBuilder sb = new StringBuilder();

                for (int i=0; i<allDigits.Length; i++)
                {
                    
                    int digit = (int)char.GetNumericValue(allDigits, i);
                    if (digit > message.Length-1 || digit< 0)
                    {
                        sb.Append(" ");
                    }
                    else
                    {
                        sb.Append(message[digit]);
                    }
                    
                }
                Console.WriteLine($"{message} == {sb.ToString()}");
            }

            

        }
    }
}
