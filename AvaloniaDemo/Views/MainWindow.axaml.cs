using System.IO;
using Avalonia.Controls;
using Avalonia.Interactivity;
using Avalonia.Platform.Storage;
using Tmds.DBus.Protocol;

namespace AvaloniaDemo.Views;

public partial class MainWindow : Window
{
    private System.Uri filePath;
    
    
    public MainWindow()
    {
        InitializeComponent();
        
        
    }

    public void GreetCommand(object sender, RoutedEventArgs args)
    {
        Message.Text = string.IsNullOrEmpty(Message.Text) ? "Button has been clicked" : "";
    }


    private async void FilePickerButton(object? sender, RoutedEventArgs e)
    {
        // Get top level from the current control. Alternatively, you can use Window reference instead.
        var topLevel = TopLevel.GetTopLevel(this);

        // Start async operation to open the dialog.
        var files = await topLevel.StorageProvider.OpenFilePickerAsync(new FilePickerOpenOptions
        {
            Title = "Open Text File",
            AllowMultiple = false
        });
        
        filePath = files[0].Path;
        Message.Text = filePath.ToString();


    }
}