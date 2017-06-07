using System;
using System.Linq;

namespace SequenceCommands
{
    class SeqCommands
    {
        public static void Main()
        {
            int sizeOfArray = int.Parse(Console.ReadLine());

            long[] array = Console.ReadLine()
                .Split(new[] {' '}, StringSplitOptions.RemoveEmptyEntries)
                .Select(long.Parse)
                .ToArray();

           do {
                string command = Console.ReadLine();
                string[] commandParams = command.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                if (commandParams[0].Equals("stop"))
                {
                    break;
                }

                int[] args = new int[2];

                if (commandParams[0].Equals("add") || commandParams[0].Equals("subtract") || commandParams[0].Equals("multiply"))
                {
                    args[0] = int.Parse(commandParams[1]);
                    args[1] = int.Parse(commandParams[2]);

                    PerformAction(ref array, commandParams[0], args);
                }
                else
                {
                    PerformAction(ref array, commandParams[0], args);
                }
                
                PrintArray(array);

            } while (true) ;
        }

        static void PerformAction(ref long[] array, string action, int[] args)
        {
            int pos = args[0] -1;
            int value = args[1];

            switch (action)
            {
                case "multiply":
                    array[pos] *= value;
                    break;
                case "add":
                    array[pos] += value;
                    break;
                case "subtract":
                    array[pos] -= value;
                    break;
                case "lshift":
                    ArrayShiftLeft(array);
                    break;
                case "rshift":
                    ArrayShiftRight(array);
                    break;
            }
        }

        private static void ArrayShiftRight(long[] array)
        {
            long temp = array[array.Length - 1];
            for (int i = array.Length - 1; i >= 1; i--)
            {
                array[i] = array[i - 1];
            }
            array[0] = temp;
        }

        private static void ArrayShiftLeft(long[] array)
        {
            long temp = array[0];
            for (int i = 0; i < array.Length - 1; i++)
            {
                array[i] = array[i + 1];
            }
            array[array.Length-1] = temp;
        }

        private static void PrintArray(long[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i] + " ");
            }
            Console.WriteLine();
        }
    }
}
