using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Palindromes
{
    class Program
    {
        static void Main()
        {
            string[] words = Console.ReadLine().Split(new char[] { ' ', ',', '.', '?', '!' }, StringSplitOptions.RemoveEmptyEntries).ToArray();
            List <string> palindromes = new List<string>();
            foreach(var word in words)
            {
                string reverseWord = new string (word.ToCharArray().Reverse().ToArray());
                if (reverseWord == word && !palindromes.Contains(word))
                {
                    palindromes.Add(word);
                }
            }

            Console.WriteLine(string.Join(", ", palindromes.OrderBy(s=>s)));
        }
    }
}
