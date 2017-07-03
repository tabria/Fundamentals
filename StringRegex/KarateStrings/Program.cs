using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace KarateStrings
{
    class Program
    {
        static void Main()
        {
            string punchStr = Console.ReadLine();
            string regex = @">(\d)";

            int sum = 0;
            while (true)
            {
                string punchStrength = Regex.Match(punchStr, regex).Groups[1].Value;
                if (string.IsNullOrEmpty(punchStrength))
                {
                    break;
                }
                int punchPower = int.Parse(punchStrength);
                int removeIndex = punchStr.IndexOf(punchStrength);
                for(int i=1; i <= punchPower+sum; i++)
                {
                    punchStr = punchStr.Remove(removeIndex, 1); 
                    try
                    {
                        if (punchStr[removeIndex].Equals('>'))
                        {
                            sum += punchPower - i;
                            break;
                        }
                    }
                    catch
                    {
                        break;
                    }        
                }
            }
            Console.WriteLine(punchStr);
        }
    }
}
