using System;
using System.Collections.Generic;
using System.Linq;

namespace OddOccurrences
{
    class Occurrences
    {
        static void Main()
        {

            List<string> strList = Console.ReadLine().ToLower().Split(' ').ToList();
            Dictionary<string, int> myDic = new Dictionary<string, int>();

            for(int i=0; i<strList.Count; i++)
            {
                string currentKey = strList[i];
                if (myDic.ContainsKey(currentKey))
                {
                    myDic[currentKey]++;
                }
                else
                {
                    myDic.Add(currentKey, 1);
                }
            }

            var result = new List<string>();
            foreach( var pair in myDic)
            {
                if (pair.Value % 2 != 0)
                {
                    result.Add(pair.Key);
                }
            }

            Console.WriteLine(string.Join(", ", result));
        }
    }
}
