using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;


namespace ConsoleApp1
{
    class Lines
    {
        static void Main()
        {

           string[] allText = File.ReadAllLines("exercise.txt");
            for(int i=1; i <=allText.Length; i+=2)
            {
                File.AppendAllText("oddOut.txt", allText[i] + Environment.NewLine);
            }
            //var oddLines = allText.Where((line, index) => index % 2 != 0);
            //File.WriteAllLines("oddLines.txt", oddLines);

        }
    }
}
