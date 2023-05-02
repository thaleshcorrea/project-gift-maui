using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using project_gift_maui.Services;
using project_gift_maui.Views;

namespace project_gift_maui.ViewModels;

public partial class MaisViewModel : BaseViewModel
{
    [ObservableProperty]
    string nomeApp;

    [ObservableProperty]
    string versaoApp;

    public MaisViewModel()
    {
        Initialize();
    }

    private void Initialize()
    {
        NomeApp = AppInfo.Current.Name;
        VersaoApp = AppInfo.Current.VersionString;
    }
}
