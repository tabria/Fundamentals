using System;


namespace intervalOfNumbers
{
    public class interval
    {
        public static void Main()
        {
            int firstNumber = int.Parse(Console.ReadLine());
            int secondNumber = int.Parse(Console.ReadLine());

            int smallNumber = firstNumber < secondNumber ? firstNumber : secondNumber;
            int bigNumber = firstNumber > secondNumber ? firstNumber : secondNumber;

            for(int i=smallNumber; i<=bigNumber; i++)
            {
                Console.WriteLine(i);
            }



        }
    }
}
