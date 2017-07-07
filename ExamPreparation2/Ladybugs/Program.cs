using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ladybugs
{
    class Program
    {
        static void Main()
        {
            int fieldSize = int.Parse(Console.ReadLine());
            int[] bugArr = new int[fieldSize];
            int[] ladybugsIndexes = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            FillBugs(bugArr, ladybugsIndexes);

            while (true)
            {
                string[] command = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToArray();
                if (command[0] == "end")
                {
                    break;
                }

                int bugCurrentIndex = int.Parse(command[0]);
                if (bugCurrentIndex > bugArr.Length - 1 || bugCurrentIndex < 0 || bugArr[bugCurrentIndex]==0)
                {
                    continue;
                }

                string direction = command[1];
                int newIndexDiff = int.Parse(command[2]);

               MoveBugs(bugArr, bugCurrentIndex, direction, newIndexDiff);
            }
            Console.WriteLine(string.Join(" ", bugArr));
        }

        private static void FillBugs(int[] bugArr, int[] ladybugsIndexes)
        {
            var indexesInField = ladybugsIndexes.Where(i => i >= 0 && i < bugArr.Length).ToArray();
            for (int i = 0; i < indexesInField.Length; i++)
            {
                bugArr[indexesInField[i]] = 1;
            }
        }
        public static void MoveBugs(int[] bugArr, int bugCurrentIndex, string direction, int newIndexDiff)
        {
            while (true)
            {
                if (newIndexDiff == 0)
                {
                    break;
                }
                int newIndex = direction == "right" ? bugCurrentIndex + newIndexDiff : bugCurrentIndex - newIndexDiff;
                bool isNotInRange = direction == "right" ? newIndex > bugArr.Length-1 : newIndex < 0;
                if (isNotInRange)
                {
                    bugArr[bugCurrentIndex] = 0;
                    break;
                }
                if (bugArr[newIndex]==1)
                {
                    newIndexDiff +=  newIndexDiff;
                }
                else
                {
                    bugArr[newIndex] = 1;
                    bugArr[bugCurrentIndex]=0;
                    break;
               }
            }
        }
    }
}
