using System;
using System.Collections.Generic;
using System.Linq;


namespace ArrayManipulator
{
    class Manipulator
    {
        static void Main()
        {
            List<int> intArr = Console.ReadLine().Split(' ').Select(int.Parse).ToList();



            while (true)
            {
                string[] commands = Console.ReadLine().Split(' ').ToArray();
                if (commands[0] == "print")
                {
                    break;
                }
                switch (commands[0])
                {
                    case "add":
                        intArr.Insert(int.Parse(commands[1]), int.Parse(commands[2]));
                        break;
                    case "addMany":
                        AddMany(commands, intArr);
                        break;
                    case "contains":
                        Console.WriteLine(intArr.IndexOf(int.Parse(commands[1])));
                        break;
                    case "remove":
                        intArr.RemoveAt(int.Parse(commands[1]));
                        break;
                    case "shift":
                        ShiftArray(commands[1], intArr);
                        break;
                    case "sumPairs":
                        SumPairs(intArr);
                        break;
                    default: break;
                }

            }

            Console.WriteLine($"[{string.Join(", ", intArr)}]");

        }

        public static void SumPairs(List<int> intArr)
        {
            for (int i = 0; i < intArr.Count; i++)
            {
                if (i == intArr.Count - 1)
                {
                    break;
                }

                intArr[i] = intArr[i] + intArr[i + 1];
                intArr.RemoveAt(i + 1);
            }
        }

        public static void ShiftArray(string pos, List<int> intArr)
        {
            int position = int.Parse(pos);
            for (int i = 1; i <= position; i++)
            {
                int firstValue = intArr[0];
                for (int k = 0; k < intArr.Count - 1; k++)
                {
                    intArr[k] = intArr[k + 1];
                }
                intArr[intArr.Count - 1] = firstValue;
            }
        }

        public static void AddMany(string[] commands, List<int> intArr)
        {
            List<int> tempList = new List<int>();
            for (int i = 2; i < commands.Length; i++)
            {
                tempList.Add(int.Parse(commands[i]));
            }

            intArr.InsertRange(int.Parse(commands[1]), tempList);
        }
    }
}
