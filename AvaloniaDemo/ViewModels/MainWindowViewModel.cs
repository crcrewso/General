﻿namespace AvaloniaDemo.ViewModels;

public class MainWindowViewModel : ViewModelBase
{
#pragma warning disable CA1822 // Mark members as static
    public string Greeting => "Welcome to Avalonia!";
    public string AltGreeting => "Top, Avalonia!";
    public string Alt2Greeting => "Hi, Avalonia!";
#pragma warning restore CA1822 // Mark members as static
}
