using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiAppRechner.ViewModel;

public partial class RechnerViewModel : ObservableObject
{
    [ObservableProperty]
    int _zahl1;
    [ObservableProperty]
    int _zahl2;
    [ObservableProperty]
    int _output;


    [RelayCommand]
    void Sum()
    {
        this.Output = this.Zahl1 + this.Zahl2;
    }
}

