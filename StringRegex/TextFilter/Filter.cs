using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextFilter
{
    class Filter
    {
        static void Main()
        {
            string[] banList = Console.ReadLine().Split(new char[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries).ToArray();
            string text = Console.ReadLine();


           foreach (var ban in banList)
            {
                text = text.Replace(ban, new string('*', ban.Length));
            }

            Console.WriteLine(text);
        }
    }
}
