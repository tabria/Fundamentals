using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MagicExchangeableWords
{
    class MagicWords
    {
        static void Main()

        {
            string[] inputStr = Console.ReadLine().Split(' ').ToArray();

            string strA = inputStr[0];
            string strB = inputStr[1];
            Console.WriteLine(IsExchangble(strA, strB).ToString().ToLower());
        }

        public static bool IsExchangble(string strA, string strB)
        {
            Dictionary<char, char> charMap = new Dictionary<char, char>();

            for(int i=0; i< strA.Length; i++)
            {
                if (charMap.ContainsKey(strA[i]))
                {
                    if (strB.Length-1 >= i && charMap[strA[i]] != strB[i])
                    {
                        return false;
                    }
                    continue;
                }
                try
                {
                    if (!charMap.ContainsValue(strB[i]))
                    {
                        charMap[strA[i]] = strB[i];
                        continue;
                    }
                    return false;
                }
                catch
                {
                    return false;
                }
            }
            bool isExchange = true;
            for (int i=0; i<strB.Length; i++)
            {
                if (!charMap.ContainsValue(strB[i]))
                {
                    isExchange = false;
                    break;
                }  
            }

            return isExchange;
        }
    }
}
