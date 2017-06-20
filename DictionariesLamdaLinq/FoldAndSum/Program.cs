using System;
using System.Collections.Generic;
using System.Linq;

namespace FoldAndSum
{
    class Program
    {
        static void Main()
        {

            int[] intArr = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int k = intArr.Length / 4;

            var first = intArr.Take(k).Reverse().ToArray();
            var last = intArr.Reverse().Take(k).ToArray();
            var middle = intArr.Skip(k).Take(2 * k).ToArray();

            var upperArray = first.Concat(last).ToArray();

            var result = upperArray.Select((x, index) =>x + middle[index]).ToList();

            Console.WriteLine(string.Join(" ", result));

        }
    }
}
