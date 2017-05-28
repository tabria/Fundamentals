using System;

namespace NeighbourWars
{
   public class Battle
    {
        public static void Main()
        {
            int peshoDamage = int.Parse(Console.ReadLine());
            int goshoDamage = int.Parse(Console.ReadLine());

            
            int peshoHealth = 100;
            int goshoHealth = 100;

            int round = 1;
            while (true)
            {
                string attacker = string.Empty;
                string defender = string.Empty;
                string weapon = string.Empty;
                int health = 0;
                if (round % 2 != 0)
                {
                    attacker = "Pesho";
                    weapon = "Roundhouse kick";
                    defender = "Gosho";
                    goshoHealth -= peshoDamage;
                } 
                else
                {
                    attacker = "Gosho";
                    weapon = "Thunderous fist";
                    defender = "Pesho";
                    peshoHealth -= goshoDamage;
                }

                if (peshoHealth <= 0 || goshoHealth <= 0)
                {
                    Console.WriteLine($"{attacker} won in {round}th round.");
                    break;
                } 
                else
                {
                    health = attacker == "Pesho" ? goshoHealth : peshoHealth;
                    Console.WriteLine($"{attacker} used {weapon} and reduced {defender} to {health} health.");
                }

                if (round % 3 == 0)
                {
                    peshoHealth += 10;
                    goshoHealth += 10;
                }
                round++;
            }

        }
    }
}
