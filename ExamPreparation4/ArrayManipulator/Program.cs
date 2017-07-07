using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayManipulator
{
    class Program
    {
        static void Main()
        {
            int[] startArr = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

            while (true)
            {
                string[] currentCommand  = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToArray();
                string command = currentCommand[0];
                if (command == "end")
                {
                    break;
                }
                switch (command)
                {
                    case "exchange":
                        ExchangeIndex(currentCommand[1], startArr);
                        break;
                    case "min":
                    case "max":
                        MinMaxElement(currentCommand, startArr);
                        break;
                    case "first":
                    case "last":
                        FirstLastElement(currentCommand, startArr);
                        break;
                    default:
                        break;
                }

            }
            Console.WriteLine("[{0}]", string.Join(", ", startArr));

        }

        public static void FirstLastElement(string[] currentCommand, int[] startArr)
        {
            int countElements = int.Parse(currentCommand[1]);
            if (countElements > startArr.Length)
            {
                Console.WriteLine("Invalid count");
                return;
            }
            List<int> elements = AddElements(startArr, currentCommand, countElements);
            PrintElements(elements);
        }

        public static List<int> AddElements(int[] startArr, string[] currentCommand, int count)
        {
            List<int> resultElements = new List<int>();
            ReverseIfOdd(startArr, currentCommand, resultElements);
            for (int i = 0; i < startArr.Length; i++)
            {
                string type = currentCommand[2];
                if (resultElements.Count >= count)
                {
                    break;
                }
                if ((type.Equals("even") && startArr[i] % 2 == 0) || (type.Equals("odd") && startArr[i] % 2 != 0))
                {
                    resultElements.Add(startArr[i]);
                }
            }
            ReverseIfOdd(startArr, currentCommand, resultElements);
            return resultElements;
        }

        public static void ReverseIfOdd(int[] startArr, string[] currentCommand, List<int> resultElements)
        {
            if (currentCommand[0].Equals("last"))
            {
                Array.Reverse(startArr);
            }
            if (resultElements.Count > 0 && currentCommand[0].Equals("last"))
            {
                resultElements.Reverse();
            }
        }

        public static void PrintElements(List<int> elements)
        {
            Console.WriteLine("[{0}]",string.Join(", ", elements));
        }

        public static void MinMaxElement(string[] currentCommand, int[] startArr)
        {
            int index = -1;
            int elementValue = currentCommand[0].Equals("max") ? int.MinValue : int.MaxValue;
            
            for(int i=0; i<startArr.Length; i++)
            {
                bool isMinMax = currentCommand[0].Equals("max") ? elementValue <= startArr[i] : elementValue >= startArr[i];
                string type = currentCommand[1];

                if ( ((type.Equals("even") && startArr[i] % 2 == 0) || (type.Equals("odd") && startArr[i] % 2 != 0)) && isMinMax)
                {
                    elementValue = startArr[i];
                    index = i;
                }
            }
            Console.WriteLine(index < 0 ? "No matches" : $"{index}");

        }

        public static void ExchangeIndex(string index, int[] startArr)
        {
            int splitIndex = int.Parse(index);
            if ( splitIndex < 0 || splitIndex > startArr.Length - 1)
            {
                Console.WriteLine("Invalid index");
                return;
            }
            int startIndexRight = splitIndex + 1;
            int lenghtRight = startArr.Length - startIndexRight;

            int[] cloneArr = new int[startArr.Length];
            Array.Copy(startArr, 0, cloneArr, 0, startArr.Length);
            Array.Copy(cloneArr, startIndexRight, startArr, 0, lenghtRight);
            Array.Copy(cloneArr, 0, startArr,lenghtRight , startIndexRight); 

        }
    }
}
