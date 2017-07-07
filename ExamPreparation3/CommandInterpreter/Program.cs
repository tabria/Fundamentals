using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace CommandInterpreter
{
    class Program
    {
        static void Main()
        {

            //string[] str = Console.ReadLine().Split(new char[] { '\t', ' ' }, StringSplitOptions.RemoveEmptyEntries).ToArray();
            string[] str = Regex.Split(Console.ReadLine(), @"\s+" );

            while (true)
            {
                string[] commands = Console.ReadLine().Split(new char[] {' ' }, StringSplitOptions.RemoveEmptyEntries).ToArray();

                if (commands[0] == "end")
                {
                    break;
                }

                switch (commands[0])
                {
                    case "reverse":
                    case "sort":
                        SortReverseArray(commands, str);
                        break;
                    case "rollLeft":
                       // RollLeft(commands, str);
                       // break;
                    case "rollRight":
                        RollRight(commands, str);
                        break;
                    default:
                        break;
                }
            }
            Console.WriteLine("[{0}]", string.Join(", ", str));
        }

        public static void RollRight(string[] commands, string[] str)
        {
            int count = int.Parse(commands[1]);
            string[] result = new string[str.Length];
            if (count%str.Length >= 0)
            {
                if (commands[0].Equals("rollLeft"))
                {
                    count *= -1;
                }
                for (int i = 0; i < str.Length; i++)
                {
                    int newIndex = i + count;
                    newIndex = newIndex % str.Length;

                    if (newIndex < 0)
                    {
                        newIndex += str.Length;
                    }

                    result[newIndex] = str[i];


                    //string lastValue = str[str.Length - 1];
                    //Array.Copy(str, 0, str, 1, str.Length - 1);
                    //str[0] = lastValue;
                }
                for (int i=0; i<str.Length; i++)
                {
                    str[i] = result[i];
                }
            }
            else
            {
                PrintInvalidParam();
                return;
            }
            
        }

        public static void RollLeft(string[] commands, string[] str)
        {
            int count = int.Parse(commands[1]);
            if (count % str.Length >= 0)
            {
                for (int i = 0; i < count % str.Length; i++)
                {
                    string firstValue = str[0];
                    Array.Copy(str, 1, str, 0, str.Length - 1);
                    str[str.Length - 1] = firstValue;
                } 
            }
            else
            {
                PrintInvalidParam();
                return;
            }
            
        }

        public static void SortReverseArray(string[] commands, string[] str)
        {

            int start = int.Parse(commands[2]);
            int count = int.Parse(commands[4]);
            long end = start + count - 1;

            if (start < 0 || start > str.Length - 1 || end > str.Length - 1 || count<0)
            {
                PrintInvalidParam();
                return;
            }
            string commandType = commands[0];
            if (commandType.Equals("sort"))
            {
                Array.Sort(str, start, count);
            }
            else
            {
                while (start < end)
                {
                    var temp = str[start];
                    str[start] = str[end];
                    str[end] = temp;
                    start++;
                    end--;
                }
            }

            //string[] strRange = new string[count];
            //for (long i = start; i <= end; i++)
            //{
            //    strRange[i-start] = str[i];
            //}
            //Array.Reverse(strRange);

            //for (long i = start; i <= end; i++)
            //{
            //    str[i] = strRange[i - start];
            //}
        }

        public static void PrintInvalidParam()
        {
            Console.WriteLine("Invalid input parameters.");
        }


    }
}
