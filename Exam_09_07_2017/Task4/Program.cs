using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{

    class PokemonEvolution
    {
        public string EvolutionType { get; set; }
        public int EvolutionIndex { get; set; }
    }

    class Program
    {
        static void Main()
        {
            Dictionary<string, List<PokemonEvolution>> pokemon = new Dictionary<string, List<PokemonEvolution>>();

            while (true)
            {
                string[] pokemonInfo = Console.ReadLine().Split(new char[] { ' ', '-', '>' }, StringSplitOptions.RemoveEmptyEntries)
                                                    .ToArray();

                var pokemonName = pokemonInfo[0];
                if (pokemonName.Equals("wubbalubbadubdub"))
                {
                    break;
                }
                if (pokemon.ContainsKey(pokemonName) && pokemonInfo.Length == 1)
                {
                    Console.WriteLine($"# {pokemonName}");
                    foreach (var evolution in pokemon[pokemonName])
                    {
                        Console.WriteLine($"{evolution.EvolutionType} <-> {evolution.EvolutionIndex}");
                    }
                    continue;
                }

                if (!pokemon.ContainsKey(pokemonName))
                {
                    if (pokemonInfo.Length == 1)
                    {
                        continue;
                    }
                    pokemon[pokemonName] = new List<PokemonEvolution>();
                }
                PokemonEvolution pokEvolution = new PokemonEvolution();

                pokEvolution.EvolutionType = pokemonInfo[1];
                pokEvolution.EvolutionIndex = int.Parse(pokemonInfo[2]);
                pokemon[pokemonInfo[0]].Add(pokEvolution);

            }
            foreach (var pokstar in pokemon)
            {
                Console.WriteLine($"# {pokstar.Key}");
                foreach (var evolution in pokstar.Value.OrderByDescending(e => e.EvolutionIndex))
                {
                    Console.WriteLine($"{evolution.EvolutionType} <-> {evolution.EvolutionIndex}");
                }
                continue;
            }
        }
    }
}
