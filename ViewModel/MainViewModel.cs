using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiApp3.ViewModel;

public class MainViewModel : INotifyPropertyChanged
{
    //example..
    string text = "";
    public string Text
    {
        get => text;
        set
        {
            text = value;
            OnPropertyChanged(nameof(text));
        }
    }

    public event PropertyChangedEventHandler? PropertyChanged;
    void OnPropertyChanged(string name) =>
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
}
