using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Text;

namespace IndexOfLetters
{
    class Letters
    {
        static void Main()
        {
            int n = 'z' - 'a';
            char[] letters = new char[n+1];
            for (int i=0; i<letters.Length; i++)
            {
               letters[i] = (char)('a'+i);
            }
            string inputLetters = File.ReadAllText("exercise.txt").ToString().ToLower();

            StringBuilder sb = new StringBuilder();

            for(int i=0; i<inputLetters.Length; i++)
            {
                for(int k=0; k<letters.Length; k++)
                {
                    if (inputLetters[i] == letters[k])
                    {
                        sb.Append(inputLetters[i]).Append(" -> ").Append(k).Append(Environment.NewLine);
                        break;
                    }
                }
            }

            File.WriteAllText("output.txt",sb.ToString());

        }
    }
}
