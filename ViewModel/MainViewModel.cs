using CommunityToolkit.Mvvm.ComponentModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiApp3.ViewModel;

public partial class MainViewModel : ObservableObject
{
    [ObservableProperty]
    private string text = "";

}