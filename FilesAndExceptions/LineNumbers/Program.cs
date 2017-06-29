using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;

namespace LineNumbers
{
    class Program
    {
        static void Main()
        {
            string[] allText = File.ReadAllLines("exercise.txt");
            var lineNumbers = allText.Select((line, index) => $"{index+1}. {line}");
            File.WriteAllLines("output.txt", lineNumbers);
            

        }
    }
}
