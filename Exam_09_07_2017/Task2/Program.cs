using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class PkenoCo
    {
        static void Main()
        {
            List<long> pokemonDistance = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(long.Parse).ToList();
            long sumRemoved = 0;
            while (pokemonDistance.Count > 0)
            {
                int currentIndex = int.Parse(Console.ReadLine());
                long elementRemove = 0;
                try
                {
                    elementRemove = pokemonDistance[currentIndex];
                    pokemonDistance.RemoveAt(currentIndex);
                }
                catch
                {
                    if (currentIndex < 0)
                    {
                        elementRemove = pokemonDistance[0];
                        pokemonDistance[0] = pokemonDistance[pokemonDistance.Count - 1];

                    }
                    if (currentIndex > pokemonDistance.Count - 1)
                    {
                        elementRemove = pokemonDistance[pokemonDistance.Count - 1];
                        pokemonDistance[pokemonDistance.Count - 1] = pokemonDistance[0];

                    }
                }

                sumRemoved += elementRemove;
                for (int i = 0; i < pokemonDistance.Count; i++)
                {
                    if (pokemonDistance[i] <= elementRemove)
                    {
                        pokemonDistance[i] += elementRemove;
                    }
                    else
                    {
                        pokemonDistance[i] -= elementRemove;
                    }
                }
            }
            Console.WriteLine(sumRemoved);
        }
    }
}
