using System;
using System.Collections.Generic;
using System.Linq;


namespace PlayCatch
{
    class Play
    {
        static void Main()
        {
            int[] arrNums = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            int countExeptions = 0;
            while(countExeptions < 3)
            {
                string[] currentCommand = Console.ReadLine().Split(' ').ToArray();

                int index = int.MinValue;
                int elementIndex = int.MinValue;
                try
                {
                    index = int.Parse(currentCommand[1]);
                    if (currentCommand.Length > 2)
                    {
                        elementIndex = int.Parse(currentCommand[2]);
                    }
                }
                catch
                {
                    countExeptions++;
                    Console.WriteLine("The variable is not in the correct format!");
                    continue;
                }

                bool firstIndex = IsIndexNotValid(arrNums.Length - 1, index);
                bool secondIndex = IsIndexNotValid(arrNums.Length - 1, elementIndex);
                if (firstIndex || (currentCommand[0] == "Print" && secondIndex))
                {
                    countExeptions++;
                    Console.WriteLine("The index does not exist!");
                    continue;
                }

                if (currentCommand[0] == "Replace")
                {
                    arrNums[index] = elementIndex;
                }
                else if (currentCommand[0] == "Print")
                {
                    for(int i=index; i<=elementIndex; i++)
                    {
                        string separator = i == index ? string.Empty : ", ";
                        Console.Write(separator + arrNums[i]);
                    }
                    Console.WriteLine();
                }
                else if (currentCommand[0] == "Show")
                {
                    Console.WriteLine(arrNums[index]);
                }
            }
            Console.WriteLine(string.Join(", ", arrNums));

        }

        static bool IsIndexNotValid(int arrayLastIndex, int index)
        {
            return index < 0 || index > arrayLastIndex;
        }
    }
}
