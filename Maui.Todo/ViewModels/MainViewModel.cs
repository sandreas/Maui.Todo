using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Maui.Todo.Views;

namespace Maui.Todo.ViewModels;

public partial class MainViewModel: BaseViewModel
{
    [ObservableProperty]
    private int _count = 0;
    
    [ObservableProperty]
    private string _buttonText = "Click me!";
    
    [RelayCommand]
    private void CounterClicked()
    {
        Count++;

        if (Count == 1)
            ButtonText = $"Clicked {Count} time";
        else
            ButtonText = $"Clicked {Count} times";

        SemanticScreenReader.Announce(ButtonText);
    }
    
    [RelayCommand]
    private async Task NavigateToSettingsAsync()
    {
        await Shell.Current.GoToAsync(nameof(SettingsPage));
    }
}