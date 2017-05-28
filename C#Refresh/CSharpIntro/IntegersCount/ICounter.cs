using System;

namespace IntegersCount
{
   public class ICounter
    {
        public static void Main()
        {
            int count = 0;
            while(true)
            {
                string currentInput = Console.ReadLine();
                try
                {
                    int a = int.Parse(currentInput);
                    count++;
                }
                catch
                {
                    break;
                }
 
            }

            Console.WriteLine(count);
        }
    }
}
