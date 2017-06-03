using System;

namespace DifferentIntegerSize
{
    class DiffInt
    {
        static void Main()
        {
            string stringType = Console.ReadLine();

            string message = string.Empty;

            try {
                message = sbyte.Parse(stringType) >= sbyte.MinValue ? message + "* sbyte" + Environment.NewLine : message;
            }
            catch { }
            try
            {
                message = byte.Parse(stringType) >= byte.MinValue ? message + "* byte" + Environment.NewLine : message;
            }
            catch { }
            try
            {
                message = short.Parse(stringType) >= short.MinValue ? message + "* short" + Environment.NewLine : message;
            }
            catch { }
            try
            {
                message = ushort.Parse(stringType) >= ushort.MinValue ? message + "* ushort" + Environment.NewLine : message;
            }
            catch { }
            try
            {
                message = int.Parse(stringType) >= int.MinValue ? message + "* int" + Environment.NewLine : message; ;
            }
            catch { }
            try
            {
                message = uint.Parse(stringType) >= uint.MinValue ? message + "* uint" + Environment.NewLine : message;
            }
            catch { }
            try
            {
                message = long.Parse(stringType) >= long.MinValue ? message + "* long" + Environment.NewLine : message; ;
            }
            catch
            {
                Console.WriteLine($"{stringType} can't fit in any type");
                return;
            }

            Console.WriteLine($"{stringType} can fit in:");
            Console.WriteLine(message);
        }
    }
}
