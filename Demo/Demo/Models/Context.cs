using System;
using System.Collections.Generic;
using Avalonia.Media;
using Avalonia.Media.Immutable;

namespace Demo.Models;

public class Context
{
    public List<Pokemon> Pokemons { get; set; }

    public Context()
    {
        Pokemons = new List<Pokemon>
        {
            new Pokemon()
            {
                Name = "Balbasaur",
                Number = "#001",
                HP = 20,
                ATK = 30,
                DEF = 5,
                SATK = 70,
                SDEF = 30,
                SPD = 94,
                ImagePath = "balbasaur.png",
                Color = new ImmutableSolidColorBrush(Colors.Green),
                Height = "0,7",
                Weight = "6,9",
                Description =
                    "There is a plant seed on its back right from the day this Pokémon is born. The seed slowly grows larger.",
                Moves = "OverGrow",
                Other = "Grass"
            },
            new Pokemon()
            {
                Name = "Aron",
                Number = "#304",
                HP = 50,
                ATK = 70,
                DEF = 100,
                SATK = 40,
                SDEF = 10,
                SPD = 10,
                ImagePath = "aron.png",
                Color = new ImmutableSolidColorBrush(Colors.Gray),
                Height = "0,4",
                Weight = "60,0",
                Description = "It eats iron ore - and sometimes railroad tracks - to build up the steel armor that protects its body.",
                Moves = "Sturdy",
                Other = "Steel"
            },
            new Pokemon()
            {
                Name = "Squirtle",
                Number = "#007",
                HP = 20,
                ATK = 30,
                DEF = 5,
                SATK = 70,
                SDEF = 30,
                SPD = 94,
                ImagePath = "squirtle.png",
                Color = new ImmutableSolidColorBrush(Colors.CornflowerBlue),
                Height = "0,5",
                Weight = "9,0",
                Description =
                    "When it retracts its long neck into its shell, it squirts out water with vigorous force.",
                Moves = "Torrent",
                Other = "Water"
            }
        };
    }
}