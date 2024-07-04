using Avalonia.Media.Immutable;

namespace Demo.Models;

public class Pokemon
{
    public string Name { get; set; }
    public string Number { get; set; }
    public string ImagePath { get; set; }
    public int HP { get; set; }
    public int ATK { get; set; }
    public int DEF { get; set; }
    public int SATK { get; set; }
    public int SDEF { get; set; }
    public int SPD { get; set; }
    public string Weight { get; set; }
    public string Height { get; set; }
    public string Moves{ get; set; }
    public string Other { get; set; }
    public string Description { get; set; }
    public ImmutableSolidColorBrush Color { get; set; }
}