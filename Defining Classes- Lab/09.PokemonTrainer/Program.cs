using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Transactions;

namespace _09.PokemonTrainer
{
    internal class StartUp
    {
        static void Main(string[] args)
        {
            List<Trainer> trainers = new List<Trainer>();

            string[] command = Console.ReadLine().Split(" ");

            while (command[0] != "Tournament")
            {
                string trainerName = command[0];
                string pokemonName = command[1];
                string element = command[2];
                int health = int.Parse(command[3]);

                Pokemon pokemon = new Pokemon()
                {
                    Name = pokemonName,
                    Element = element,
                    Health = health
                };

                bool isContained = trainers.Exists(x => x.Name == trainerName);

                if (isContained)
                {
                    trainers.Find(x => x.Name == trainerName).Pokemons.Add(pokemon);
                }
                else
                {
                    Trainer trainer = new Trainer()
                    {
                        Name = trainerName,
                        Pokemons = new List<Pokemon>() { pokemon }
                    };

                    trainers.Add(trainer);
                }

                command = Console.ReadLine().Split(" ");
            }

            string tournamentElement = Console.ReadLine();

            while (tournamentElement != "End")
            {
                foreach (var trainer in trainers)
                {
                    var containsElement = trainer.Pokemons.Exists(x => x.Element == tournamentElement);

                    if (containsElement)
                    {
                        trainer.Badges++;
                    }
                    else
                    {
                        foreach (var pokemon in trainer.Pokemons)
                        {
                            pokemon.Health -= 10;
                        }

                        trainer.Pokemons.RemoveAll(x => x.Health <= 0);
                    }
                }

                tournamentElement = Console.ReadLine();
            }

            foreach (var trainer in trainers.OrderByDescending(x => x.Badges))
            {
                Console.WriteLine($"{trainer.Name} {trainer.Badges} {trainer.Pokemons.Count}");
            }
        }
    }
}
