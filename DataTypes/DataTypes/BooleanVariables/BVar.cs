using System;


namespace BooleanVariables
{
    class BVar
    {
        static void Main()
        {
            bool type1 = Convert.ToBoolean(Console.ReadLine());
            Console.WriteLine(type1 == true ? "Yes" : "No");
        }
    }
}
