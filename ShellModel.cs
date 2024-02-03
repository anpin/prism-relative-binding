using System.ComponentModel;
using System.Windows.Input;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace prism_relative_binding;

public record CmdArgs(Picker btn);

public interface IShellModel
{
    IRelayCommand<CmdArgs> PickCityCommand { get; } 
}
internal partial class ShellModel : IShellModel
{
    int count = 0;
    
    [RelayCommand]
    private  void PickCity(CmdArgs args)
    {
        args.btn.Title = $"A city was picked {++count} times";
    }
}

public interface IIPageModel
{
    IList<string> Items { get;  }
    string SelectedItem { get;  }
}
[ObservableObject]
internal partial class PageModel : IIPageModel
{
    private const string none = "Pick a city";
    public IList<string> Items  { get; } = new List<string>()
    {
       none ,  "Cape Town", "Dakar", "Marrakesh", "Alexandria", "Addis Ababa"
    };
    [ObservableProperty]
    string selectedItem  = none;
    
}