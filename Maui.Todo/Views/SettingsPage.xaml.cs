using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Maui.Todo.ViewModels;

namespace Maui.Todo.Views;

public partial class SettingsPage : ContentPage
{
    public SettingsPage(SettingsViewModel vm)
    {
        InitializeComponent();
        BindingContext = vm;
    }

    protected override void OnNavigatedTo(NavigatedToEventArgs args)
    {
        
    }
}