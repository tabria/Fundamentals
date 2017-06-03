using System;


namespace ExchangeVariableValue
{
    public class Exchange
    {
       public static void Main()
        {
            int a = 5;
            int b = 10;

            Console.WriteLine("Before:" + Environment.NewLine + $"a = {a}" + Environment.NewLine + $"b = {b}");

            int tempA = a;
            a = 10;
            b = tempA;

            Console.WriteLine("After:" + Environment.NewLine + $"a = {a}" + Environment.NewLine + $"b = {b}");

        }
    }
}
