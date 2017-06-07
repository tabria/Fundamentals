using System;

namespace BlankReceipt
{
    public class Receipt
    {
        public static void Main()
        {

            PrintHeaderFooter("CASH RECEIPT", "up", '-', 30);
            PrintBody();
            PrintHeaderFooter('\u00A9'+" SoftUni", "down", '-', 30);

        }

        private static void PrintBody()
        {
            PrintLine("Charged to", '_', 30);
            PrintLine("Received by", '_', 30);
        }

        public static void PrintLine(string text, char lineFiller, int length)
        {
            Console.WriteLine(text + new String(lineFiller, length - text.Length));
        }

        private static void PrintHeaderFooter(string text, string textPostion, char spacer, int length)
        {
            if (textPostion == "up")
            {
                Console.WriteLine(text);
                Console.WriteLine(new String(spacer, length));
                return;
            }
            Console.WriteLine(new String(spacer, length));
            Console.WriteLine(text);
        }

    }
}
