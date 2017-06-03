using System;


namespace StringsObjects
{
    class SANDO
    {
        static void Main()
        {

            string hello = Console.ReadLine();
            string world = Console.ReadLine();

            object helloWorld = (hello + " " + world);
            Console.WriteLine((string)helloWorld);

        }
    }
}
