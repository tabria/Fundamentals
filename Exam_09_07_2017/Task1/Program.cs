using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam
{
    class ExamFund
    {
        static void Main()
        {
            int pokePower = int.Parse(Console.ReadLine());
            int pokeDistance = int.Parse(Console.ReadLine());
            int pokeExhaust = int.Parse(Console.ReadLine());
            int originalPower = pokePower;

            int targetCount = 0;

            while (pokePower >= pokeDistance)
            {
                if (pokePower == (originalPower - pokePower) && pokeExhaust > 1)
                {
                    pokePower = pokePower / pokeExhaust;
                }
                else
                {
                    pokePower = pokePower - pokeDistance;
                    targetCount = targetCount + 1;
                }
            }

            Console.WriteLine(pokePower);
            Console.WriteLine(targetCount);
        }
    }
}
