using System.Windows;
using PdfReviewApp.Desktop.ViewModels;

namespace PdfReviewApp.Desktop.Views;

public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();
        DataContext = new MainWindowViewModel();
    }
}
