using System;
using System.Collections.Generic;
using System.Linq;


namespace AppendLists
{
    class Append
    {
        static void Main()
        {
            List<string> fullList = Console.ReadLine().Split('|').ToList();
            List<int> result = new List<int>();

            for(int i=fullList.Count-1; i>=0; i--)
            {
                List<int> currentList = fullList[i].Split(new[] {' '}, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();
                result.AddRange(currentList);
            }

            Console.WriteLine(string.Join(" ", result));
        }
    }
}
