using System.Collections.ObjectModel;
using System.Linq;
using System.Reactive;
using System.Reactive.Linq;
using Demo.Models;
using ReactiveUI;

namespace Demo.ViewModels;

public class PokedexListViewModel : ViewModelBase
{
    private MainViewModel _viewModel;
    private ObservableCollection<PokemonViewModel> _pokemons;
    private PokemonViewModel _pokemonViewModel;
    
    public PokedexListViewModel(MainViewModel viewModel)
    {
        PokemonViewModel = null;
        _viewModel = viewModel;
        _pokemons = new ObservableCollection<PokemonViewModel>(
            Helper.Context.Pokemons.Select(x => new PokemonViewModel(x)));
        SetPokemonCommand = ReactiveCommand.Create<PokemonViewModel>(SetPokemon);
        
        this.WhenAnyValue(x => x.PokemonViewModel)
            .Where(item => item != null)
            .Select(x => x)
            .InvokeCommand(SetPokemonCommand);
    }

    private void SetPokemon(PokemonViewModel pokemonViewModel)
    {
        PokemonStatsViewModel pokemonStatsViewModel = new PokemonStatsViewModel(pokemonViewModel.Pokemon,_viewModel);
        _viewModel.CurrentView = pokemonStatsViewModel;
    }
    private  ReactiveCommand<PokemonViewModel,Unit> SetPokemonCommand { get; }
    public PokemonViewModel PokemonViewModel
    {
        get => _pokemonViewModel;
        set => this.RaiseAndSetIfChanged(ref _pokemonViewModel, value);
    }
    public ObservableCollection<PokemonViewModel> Pokemons
    {
        get => _pokemons;
        set => this.RaiseAndSetIfChanged(ref _pokemons, value);
    }
}