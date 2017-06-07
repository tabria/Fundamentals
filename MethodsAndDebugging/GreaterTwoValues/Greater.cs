using System;


namespace GreaterTwoValues
{
    class Greater
    {
        static void Main()
        {

            string valueType = Console.ReadLine();
            string valueOne = Console.ReadLine();
            string valueTwo = Console.ReadLine();

            string greater = string.Empty;

            if (valueType == "string")
            {
                greater = GetGreaterValue(valueOne, valueTwo);
            }
            else if(valueType == "int")
            {
                int valueOneInt = int.Parse(valueOne);
                int valueTwoInt = int.Parse(valueTwo);
                greater = GetGreaterValue(valueOneInt, valueTwoInt);
            }
            else if(valueType == "char")
            {
                char valueOneChar = char.Parse(valueOne);
                char valueTwoChar = char.Parse(valueTwo);
                greater = GetGreaterValue(valueOneChar, valueTwoChar);
            }

            Console.WriteLine(greater);
            

        }

        private static string GetGreaterValue(char valueOne, char valueTwo)
        {
            return valueOne >= valueTwo ? valueOne.ToString() : valueTwo.ToString();
        }

        private static string GetGreaterValue(int valueOne, int valueTwo)
        {
            return valueOne >= valueTwo ? valueOne.ToString() : valueTwo.ToString();
        }

        public static string GetGreaterValue(string valueOne, string valueTwo)
        {
                int compareResult = valueOne.CompareTo(valueTwo);
                return compareResult >= 0 ? valueOne : valueTwo;
           
        }
    }
}
