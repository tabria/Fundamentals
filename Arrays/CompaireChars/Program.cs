using System;
using System.Linq;

namespace CompaireChars
{
    class Program
    {
        static void Main()
        {

            char[] arrOne = Console.ReadLine().Split(' ').Select(char.Parse).ToArray();
            char[] arrTwo = Console.ReadLine().Split(' ').Select(char.Parse).ToArray();

            string condition = "equal";
            int cycle = arrOne.Length <= arrTwo.Length ? arrOne.Length : arrTwo.Length;
            for (int i=0; i < cycle; i++)
            {
                if (arrOne[i] < arrTwo[i])
                {
                    condition = "one";
                    break;
                }
                else if (arrOne[i] == arrTwo[i])
                {
                    continue;
                }
                else if (arrOne[i] > arrTwo[i])
                {
                    condition = "two";
                    break;
                }
            }


            if (condition == "equal" && arrOne.Length <= arrTwo.Length)
            {
                condition = "one";
            }
            else if (condition == "equal" && arrTwo.Length < arrOne.Length)
            {
                condition = "two";
            }

            if (condition == "one")
            {
                Console.WriteLine(string.Join("", arrOne));
                Console.WriteLine(string.Join("", arrTwo));
            }
            else
            {
                Console.WriteLine(string.Join("", arrTwo));
                Console.WriteLine(string.Join("", arrOne));
            }

        }
    }
}
