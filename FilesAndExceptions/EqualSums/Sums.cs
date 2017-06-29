using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace EqualSums
{
    class Sums
    {
        static void Main()
        {
            int[] inputNumbers = File.ReadAllText("exercise.txt").Split(' ').Select(int.Parse).ToArray();

            StringBuilder sb = new StringBuilder();

            if (inputNumbers.Length==1)
            {
                sb.Append(0).Append(Environment.NewLine);
            }
            else
            {
                int sumLeft = 0;
                int sumRight = inputNumbers.Sum(n => n);
                for (int i = 0; i < inputNumbers.Length; i++)
                {
                    int rightSum = sumRight;
                    if (i - 1 < 0 || i + 1 > inputNumbers.Length)
                    {
                        sb.Append("no");
                        continue;
                    }
                    sumLeft += inputNumbers[i - 1];
                    rightSum = rightSum - sumLeft - inputNumbers[i];
                    if (sumLeft == rightSum)
                    {
                        sb.Clear();
                        sb.Append(i);
                        break;
                    }
                }
            }

            Console.WriteLine(sb);

        }
    }
}
