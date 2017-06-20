using System;
using System.Collections.Generic;
using System.Linq;


namespace CountRealNumbers
{
    class RealNumbers
    {
        static void Main()
        {

            List<double> numbers = Console.ReadLine().Split(' ').Select(double.Parse).ToList();
            SortedDictionary<double, int> myDict = new SortedDictionary<double, int>();

            for (int i=0; i<numbers.Count; i++)
            {
                double currentKey= numbers[i];
                if (myDict.ContainsKey(currentKey))
                {
                    myDict[currentKey]++;
                }
                else
                {
                    myDict.Add(currentKey, 1);
                }
            }

            foreach(var item in myDict)
            {
                Console.WriteLine($"{item.Key} -> {item.Value}");
            }

        }
    }
}
