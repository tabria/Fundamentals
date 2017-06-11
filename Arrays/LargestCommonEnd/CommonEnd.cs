using System;
using System.Linq;

namespace LargestCommonEnd
{
    class CommonEnd
    {
        static void Main()
        {
            string[] arrOne = Console.ReadLine().Split(' ').ToArray();
            string[] arrTwo = Console.ReadLine().Split(' ').ToArray();

            int commonElements = ScanFromLeft(arrOne, arrTwo);
            if (commonElements == 0)
            {
                commonElements = ScanFromRight(arrOne, arrTwo);
            }

            Console.WriteLine(commonElements);
        }

        public static int ScanFromLeft(string[] arrayOne, string[] arrayTwo)
        {
            int count = 0;
            for (int i = 0; i < arrayOne.Length; i++)
            {
                int prevCount = count;
                for (int k = 0; k < arrayTwo.Length; k++)
                {
                    if (arrayOne[i] == arrayTwo[k])
                    {
                        if (count == 0 && i > 0)
                        {
                            break;
                        }
                        count++;
                        break;
                    }
                }
                if (prevCount == count)
                {
                    break;
                }
            }

            return count;
        }

        public static int ScanFromRight(string[] arrayOne, string[] arrayTwo)
        {
            int count = 0;
            for (int i = arrayOne.Length-1; i > 0; i--)
            {
                int prevCount = count;
                for (int k = arrayTwo.Length-1; k >0; k--)
                {
                    if (arrayOne[i] == arrayTwo[k])
                    {
                        if (count == 0 && i < arrayOne.Length-1)
                        {
                            break;
                        }
                        count++;
                        break;
                    }
                }
                if (prevCount == count)
                {
                    break;
                }
            }

            return count;
        }
    }
}
