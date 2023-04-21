using Maui.Todo.ViewModels;

namespace Maui.Todo.Views;

public partial class MainPage : ContentPage
{


    public MainPage(MainViewModel vm)
    {
        InitializeComponent();
        BindingContext = vm;
    }

}