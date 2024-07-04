using System;
using System.IO;
using System.Linq;
using System.Net;
using System.Windows.Input;
using Avalonia.Media;
using Avalonia.Media.Imaging;
using Avalonia.Media.Immutable;
using Demo.Models;
using ReactiveUI;

namespace Demo.ViewModels;

public class PokemonStatsViewModel : ViewModelBase
{
    private MainViewModel _viewModel;
    private Pokemon _pokemon;
    private string _name ;
    private string _number ;
    private string _imagePath ;
    private Bitmap _image ;
    private int _HP ;
    private int _ATK ;
    private int _DEF ;
    private int _SATK ;
    private int _SDEF ;
    private int _SPD ;

    public PokemonStatsViewModel()
    {
        var pokemon = new Pokemon()
        {
            Name = "Balbasaur",
            Number = "#001",
            HP = 20,
            ATK = 30,
            DEF = 5,
            SATK = 70,
            SDEF = 30,
            SPD = 94,
            ImagePath = "Aron.png",
            Color = new ImmutableSolidColorBrush(Colors.Green),
            Height = "2,1",
            Weight = "12",
            Description =
                "There is a plant seed on its back right from the day this Pokémon is born. The seed slowly grows larger.",
            Moves = "OverGrow",
            Other = "Grass"
        };
        _pokemon = pokemon;
        Name = pokemon.Name;
        Number = pokemon.Number;
        ImagePath = pokemon.ImagePath;
        HP = pokemon.HP;
        ATK = pokemon.ATK;
        DEF = pokemon.DEF;
        SATK = pokemon.SATK;
        SDEF = pokemon.SDEF;
        SPD = pokemon.SPD;
        Weight = pokemon.Weight;
        Height = pokemon.Height;
        Moves = pokemon.Moves;
        Other = pokemon.Other;
        Color = pokemon.Color;
        Description = pokemon.Description;

        BackCommand = ReactiveCommand.Create(() => { });
    }

    public PokemonStatsViewModel(Pokemon pokemon, MainViewModel viewModel)
    {
        _viewModel = viewModel;
        _pokemon = pokemon;
        Name = pokemon.Name;
        Number = pokemon.Number;
        ImagePath = pokemon.ImagePath;
        HP = pokemon.HP;
        ATK = pokemon.ATK;
        DEF = pokemon.DEF;
        SATK = pokemon.SATK;
        SDEF = pokemon.SDEF;
        SPD = pokemon.SPD;
        Weight = pokemon.Weight;
        Height = pokemon.Height;
        Moves = pokemon.Moves;
        Other = pokemon.Other;
        Color = pokemon.Color;
        Description = pokemon.Description;

        BackCommand = ReactiveCommand.Create(() =>
        {
            _viewModel.CurrentView = new PokedexListViewModel(_viewModel);
        });
    }
    
    public Pokemon Pokemon
    {
        get => _pokemon;
        set => this.RaiseAndSetIfChanged(ref _pokemon, value);
    }
    public string Name { get; set; }
    public string Number { get; set; }
    public string ImagePath { get; set; }
    public Bitmap Image => new Bitmap(Path.Combine(AppContext.BaseDirectory, "drawable", ImagePath));
    public int HP { get; set; }
    public int ATK { get; set; }
    public int DEF { get; set; }
    public int SATK { get; set; }
    public int SDEF { get; set; }
    public int SPD { get; set; }
    public string Weight { get; set; }
    public string Height { get; set; }
    public string Moves{ get; set; }
    
    public string Other{ get; set; }
    public ImmutableSolidColorBrush Color { get; set; }
    public string Description { get; set; }
    public ICommand BackCommand { get; }
}