using System;
using System.Collections.Generic;
using System.Linq;


namespace ChangeList
{
    class Change
    {
        static void Main()
        {
            List<int> numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            List<string> commands = new List<string>();

            while (true)
            {
                commands = Console.ReadLine().Split(' ').ToList();
                if (commands[0] == "Odd" || commands[0] == "Even")
                {
                    break;
                }

                if (commands[0] == "Insert")
                {
                    numbers.Insert(int.Parse(commands[2]), int.Parse(commands[1]));
                }
                else if (commands[0] == "Delete")
                {
                    removeAllInstances(numbers, commands);
                }
            }


            PrintResult(numbers, commands);

        }

        public static void PrintResult(List<int> numbers, List<string> commands)
        {
            for (int i=0; i<numbers.Count; i++)
            {
                if (commands[0] == "Even" && numbers[i] % 2 == 0)
                {
                    Console.Write($"{numbers[i]} ");
                }
                else if (commands[0] == "Odd" && numbers[i] % 2 != 0)
                {
                    Console.Write($"{numbers[i]} ");
                }
            }
        }

        public static void removeAllInstances(List<int> numbers, List<string> commands)
        {
            int removeElement = int.Parse(commands[1]);
            bool removed = true;
            while (removed)
            {
               removed = numbers.Remove(removeElement);
            }
        }
    }
}
