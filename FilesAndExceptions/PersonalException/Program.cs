using System;
using System.Collections.Generic;
using System.Linq;


namespace PersonalException
{

    class Program
    {
        static void Main()
        {

            while (true)
            {
                try
                {
                    int number = int.Parse(Console.ReadLine());
                    if (number < 0)
                    {
                        throw new MyExeption();
                    }
                    Console.WriteLine(number);
                }
                catch (MyExeption me)
                {

                    Console.WriteLine(me.Message);
                    return;

                }
            }

        }
    }
}
