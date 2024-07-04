using System;
using System.IO;
using Avalonia;
using Avalonia.Media.Imaging;
using Avalonia.Platform;
using Demo.Models;
using ReactiveUI;

namespace Demo.ViewModels;

public class PokemonViewModel : ViewModelBase
{
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
    
    public PokemonViewModel(Pokemon pokemon)
    {
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
    
}