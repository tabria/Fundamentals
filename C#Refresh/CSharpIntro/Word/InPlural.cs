using System;

namespace Word
{
    public class InPlural
    {
        public static void Main()
        {

            string noun = Console.ReadLine();

            string strToPrint = string.Empty;


            if (noun.EndsWith("y"))
            {
                strToPrint = noun.Remove(noun.Length - 1) + "ies";
            }
            else if (noun.EndsWith("o") || noun.EndsWith("ch") || noun.EndsWith("s") || noun.EndsWith("sh") || noun.EndsWith("x") || noun.EndsWith("z"))
            {
                strToPrint = noun + "es";
            }
            else
            {
                strToPrint = noun + "s";
            }


            Console.WriteLine(strToPrint);

        }
    }
}
