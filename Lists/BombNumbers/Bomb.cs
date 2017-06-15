using System;
using System.Collections.Generic;
using System.Linq;


namespace BombNumbers
{
    class Bomb
    {
        static void Main()
        {
            List<int> bombNumbers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            List<int> bombInfo = Console.ReadLine().Split(' ').Select(int.Parse).ToList();


           while (bombNumbers.Contains(bombInfo[0]))
            {
                RemoveNeighbors(bombNumbers, bombInfo, "left");
                RemoveNeighbors(bombNumbers, bombInfo, "right");

                int specialBombNumberIndex = bombNumbers.IndexOf(bombInfo[0]);
                bombNumbers.RemoveAt(specialBombNumberIndex);
            }
            

            Console.WriteLine(bombNumbers.Sum());
        }

        public static void RemoveNeighbors(List<int> bombNumbers, List<int> bombInfo, string direction)
        {
           for (int i =0; i<bombInfo[1]; i++)
            {
                int specialBombNumberIndex = bombNumbers.IndexOf(bombInfo[0]);
                if (direction == "left")
                {
                    try { bombNumbers.RemoveAt(specialBombNumberIndex - 1); }
                    catch {  break; }  
                }
                else
                {
                    try { bombNumbers.RemoveAt(specialBombNumberIndex + 1); }
                    catch { break;  }
                }
                
            }
        }
    }
}
