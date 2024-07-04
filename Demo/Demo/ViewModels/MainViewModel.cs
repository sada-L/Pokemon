using ReactiveUI;

namespace Demo.ViewModels;

public class MainViewModel : ViewModelBase
{
    private ViewModelBase _currentView;

    public MainViewModel()
    {
        
        CurrentView = new PokedexListViewModel(this);
    }
    public ViewModelBase CurrentView
    {
        get => _currentView;
        set => this.RaiseAndSetIfChanged(ref _currentView, value);
    }
}
