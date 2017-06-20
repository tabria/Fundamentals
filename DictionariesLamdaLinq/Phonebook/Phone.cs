using System;
using System.Collections.Generic;
using System.Linq;


namespace Phonebook
{
    class Phone
    {
        static void Main()
        {
            SortedDictionary<string, string> phoneBook = new SortedDictionary<string, string>();

            while (true)
            {
                string[] personInfo = Console.ReadLine().Split(' ').ToArray();

                string action = personInfo[0];
                if (action == "END")
                {
                    break;
                }

                if (action == "A")
                {
                    AddPerson(personInfo, phoneBook);
                }
                else if(action == "S")
                {
                    PrintPerson(personInfo, phoneBook);
                }
                else if (action == "ListAll")
                {
                    PrintLexographically(personInfo, phoneBook);
                }

            }


        }

        public static void PrintLexographically(string[] personInfo, SortedDictionary<string, string> phoneBook)
        {
           foreach(var pair in phoneBook)
            {
                Console.WriteLine($"{pair.Key} -> {pair.Value}");
            }
        }

        public static void PrintPerson(string[] personInfo, SortedDictionary<string, string> phoneBook)
        {
            string personName = personInfo[1];
            if (phoneBook.ContainsKey(personName))
            {
                Console.WriteLine($"{personName} -> {phoneBook[personName]}");
            }
            else
            {
                Console.WriteLine($"Contact {personName} does not exist.");
            }
        }

        public static void AddPerson(string[] personInfo, SortedDictionary<string, string> phoneBook)
        {
            string personName = personInfo[1];
            string personPhone = personInfo[2];
            phoneBook[personName] = personPhone;
        }
    }
}
