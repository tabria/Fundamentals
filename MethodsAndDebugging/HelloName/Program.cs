using System;

namespace HelloName
{
    class Program
    {
        static void Main()
        {
            string name = Console.ReadLine();

            PrintHello(name);
        }

        public static void PrintHello(string name)
        {
            Console.WriteLine($"Hello, {name}!");
        }
    }
}
