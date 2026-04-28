using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows.Input;
using PdfReviewApp.Desktop.Commands;

namespace PdfReviewApp.Desktop.ViewModels;

public sealed class MainWindowViewModel : INotifyPropertyChanged
{
    private bool _isSyncEnabled;
    private string _statusMessage = "準備完了";
    private string _selectedTool = "選択";

    public MainWindowViewModel()
    {
        OpenPdfCommand = new RelayCommand(_ => ExecuteOpenPdf());
        SelectHighlighterCommand = new RelayCommand(_ => ExecuteSelectTool("マーカー"));
        SelectRedlineCommand = new RelayCommand(_ => ExecuteSelectTool("赤線"));
        SelectTextNoteCommand = new RelayCommand(_ => ExecuteSelectTool("テキスト"));
        SaveCommand = new RelayCommand(_ => ExecuteSave());
    }

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
            StatusMessage = _isSyncEnabled ? "同期表示: ON" : "同期表示: OFF";
        }
    }

    public string SelectedTool
    {
        get => _selectedTool;
        private set
        {
            if (_selectedTool == value)
            {
                return;
            }

            _selectedTool = value;
            OnPropertyChanged();
        }
    }

    public string StatusMessage
    {
        get => _statusMessage;
        private set
        {
            if (_statusMessage == value)
            {
                return;
            }

            _statusMessage = value;
            OnPropertyChanged();
        }
    }

    public ICommand OpenPdfCommand { get; }
    public ICommand SelectHighlighterCommand { get; }
    public ICommand SelectRedlineCommand { get; }
    public ICommand SelectTextNoteCommand { get; }
    public ICommand SaveCommand { get; }

    public event PropertyChangedEventHandler? PropertyChanged;

    private void ExecuteOpenPdf()
    {
        StatusMessage = $"PDFを開く処理は未接続です（{DateTime.Now:HH:mm:ss}）";
    }

    private void ExecuteSelectTool(string toolName)
    {
        SelectedTool = toolName;
        StatusMessage = $"ツール切替: {toolName}（{DateTime.Now:HH:mm:ss}）";
    }

    private void ExecuteSave()
    {
        StatusMessage = $"保存処理は未接続です（{DateTime.Now:HH:mm:ss}）";
    }

    private void OnPropertyChanged([CallerMemberName] string? propertyName = null)
        => PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
}
