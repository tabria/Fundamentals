using System;
using System.Collections.Generic;
using System.Linq;


namespace MinerTask
{
    class Miner
    {
        static void Main()
        {
            Dictionary<string, string> miner = new Dictionary<string, string>();

            string metal = string.Empty;
            while (true)
            {
                string input = Console.ReadLine();

                if (input == "stop")
                {
                    break;
                }

                if (string.IsNullOrEmpty(metal))
                {
                    metal = input;
                }
                else
                {
                    if (miner.ContainsKey(metal))
                    {
                        miner[metal] = miner.Sum(x => int.Parse(x.Value) + int.Parse(input)).ToString();
                    }
                    else
                    {
                        miner[metal] = input;
                    }

                    metal = string.Empty;
                }

            }

            Console.WriteLine(string.Join("", miner.Select(kvp => kvp.Key + " -> " + kvp.Value + Environment.NewLine)));

        }
    }
}
