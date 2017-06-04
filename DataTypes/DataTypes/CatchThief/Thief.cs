using System;


namespace CatchThief
{
    class Thief
    {
        static void Main()
        {
            string idType = Console.ReadLine();
            int cycles = int.Parse(Console.ReadLine());

            long thiefID = long.MinValue;
            for(int i=0; i<cycles; i++)
            {

                if (idType == "sbyte")
                {
                    try
                    {
                        sbyte currentId = sbyte.Parse(Console.ReadLine());
                        thiefID = thiefID < currentId ? currentId : thiefID;
                    }
                    catch { }
                }
                else if (idType == "int")
                {
                    try
                    {
                        int currentId = int.Parse(Console.ReadLine());
                        thiefID = thiefID < currentId ? currentId : thiefID;
                    }
                    catch { }
                }
                else if (idType == "long")
                {
                    try
                    {
                        long currentId = long.Parse(Console.ReadLine());
                        thiefID = thiefID < currentId ? currentId : thiefID;
                    }
                    catch { }
                }

            }
            Console.WriteLine(thiefID);

        }
    }
}
