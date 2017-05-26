using System;


namespace DebitCardNumber
{
   public class Program
    {
       public static void Main()
        {
            int firstPart = int.Parse(Console.ReadLine());
            int secondPart = int.Parse(Console.ReadLine());

            var thirdPart = int.Parse(Console.ReadLine());
            var fourthPart = int.Parse(Console.ReadLine());

            Console.WriteLine($"{firstPart:D4} {secondPart:D4} {thirdPart:D4} {fourthPart:D4}");

        }
    }
}
