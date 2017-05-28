using System;

namespace EKS
{
    public class XFigure
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            for(int i=0; i<(n-1)/2; i++)
            { 
                Console.WriteLine("{0}x{1}x", new String(' ', i), new String(' ', n-2*i-2));
            }
            Console.WriteLine("{0}x", new String(' ', (n-1)/2));
            for (int i = ((n-1)/2)-1; i>=0; i--)
            {
                Console.WriteLine("{0}x{1}x", new String(' ', i), new String(' ', n - 2*i-2 ));
            }
        }
    }
}
