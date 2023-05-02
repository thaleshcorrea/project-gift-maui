using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using project_gift_maui.Services;
using project_gift_maui.Views;

namespace project_gift_maui.ViewModels;

public partial class HomeViewModel : BaseViewModel
{
    [ObservableProperty]
    string nomeUsuario;

    private readonly IFirebaseAuthentication _auth;
    public HomeViewModel(IFirebaseAuthentication auth)
    {
        _auth = auth;

        Initialize();
    }

    private void Initialize()
    {
        NomeUsuario = _auth.GetUsername();
    }

    [RelayCommand]
    async Task OpenPerfilPage()
    {
        await Shell.Current.GoToAsync($"{nameof(PerfilPage)}");
    }
}
