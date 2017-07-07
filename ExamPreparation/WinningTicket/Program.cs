using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace WinningTicket
{
    class Program
    {
        static void Main()
        {

            string[] tickets = Console.ReadLine().Split(new char[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries).ToArray();
            string[] winners = new string[] { "@", "#", "^", "$" };

            foreach( var ticket in tickets)
            {
                if (ticket.Length != 20)
                {
                    Console.WriteLine("invalid ticket");
                    continue;
                }
                else
                {
                    string leftString = ticket.Substring(0, 10);
                    string rightString = ticket.Substring(10);
                    bool isWinning = false;
                    foreach(var winItem in winners)
                    {
                        string regex = $"(?:\\{winItem}){{6,10}}";
                        string leftSideMatch = Regex.Match(leftString, regex).Value;
                        string rightSideMatch = Regex.Match(rightString, regex).Value;
                        if (!string.IsNullOrEmpty(leftSideMatch) && !string.IsNullOrEmpty(rightSideMatch))
                        {
                            isWinning = true;
                            if (leftSideMatch.Length == 10 && rightSideMatch.Length == 10)
                            {
                                Console.WriteLine($"ticket \"{ticket}\" - 10{winItem} Jackpot!");
                            }
                            else
                            {
                                int countSymbols = leftSideMatch.Length <= rightSideMatch.Length ? leftSideMatch.Length : rightSideMatch.Length;
                                 Console.WriteLine($"ticket \"{ticket}\" - {countSymbols}{winItem}");
                            }

                            break;
                        }
                    }
                    if (!isWinning)
                    {
                        Console.WriteLine($"ticket \"{ticket}\" - no match");
                    }
                }
            }
        }
    }
}
