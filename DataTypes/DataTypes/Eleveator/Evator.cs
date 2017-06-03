using System;

namespace Eleveator
{
    public class Evator
    {
        public static void Main()
        {
            int peoples = int.Parse(Console.ReadLine());
            int capacity = int.Parse(Console.ReadLine());

            int courses = (int)Math.Ceiling(peoples / (decimal)capacity);
            Console.WriteLine(courses);
        }
    }
}
