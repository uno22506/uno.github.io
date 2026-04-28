using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace PdfReviewApp.Desktop.ViewModels;

public sealed class MainWindowViewModel : INotifyPropertyChanged
{
    private bool _isSyncEnabled;

    public bool IsSyncEnabled
    {
        get => _isSyncEnabled;
        set
        {
            if (_isSyncEnabled == value)
            {
                return;
            }

            _isSyncEnabled = value;
            OnPropertyChanged();
        }
    }

    public event PropertyChangedEventHandler? PropertyChanged;

    private void OnPropertyChanged([CallerMemberName] string? propertyName = null)
        => PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
}
