﻿using System;
using System.Linq;

namespace ManipulateArray
{
    class Manipulate
    {
        static void Main()
        {
            string[] arr = Console.ReadLine().Split(' ').ToArray();
            int cycles = int.Parse(Console.ReadLine());

            for(int i=0; i<cycles; i++)
            {
                string[] command = Console.ReadLine().Split(' ').ToArray();
                
                if (command[0] == "Reverse")
                {
                    ReverseArray(arr);
                }
                else if(command[0] == "Distinct")
                {
                    arr = DistinctArray(arr);
                }
                else if (command[0] == "Replace")
                {
                    ReplaceArray(arr, command[1], command[2]);
                }
            }

            Console.WriteLine(string.Join(", ", arr));
        }

        public static void ReplaceArray(string[] arr, string replaceIndex, string value)
        {
            int index = int.Parse(replaceIndex);
            arr[index] = value;
        }

        public static string[] DistinctArray(string[] arr)
        {
            string uniqElements = String.Empty;
            for (int i =0; i<arr.Length; i++)
            {
                int countRepeat = 0;
                for (int k=0; k<arr.Length; k++)
                {
                    if (arr[i]==arr[k])
                    {
                        countRepeat++;
                        arr[k] = countRepeat > 1 ? null :  arr[k];
                        if (!string.IsNullOrEmpty(arr[k]))
                        {
                            uniqElements += arr[k] + " ";
                        }
                    }
                }
            }
            string[] newArr = uniqElements.Trim().Split(' ').ToArray();
            return newArr;
        }

        public static void ReverseArray(string[] arr)
        {
            for (int i=0; i<arr.Length/2; i++)
            {
                string temp = arr[i];
                arr[i] = arr[arr.Length - 1 - i];
                arr[arr.Length - 1 - i] = temp;
            }
        }
    }
}
