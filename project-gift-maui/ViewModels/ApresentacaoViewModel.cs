using CommunityToolkit.Mvvm.Input;
using project_gift_maui.Services;
using project_gift_maui.Views;

namespace project_gift_maui.ViewModels;

public partial class ApresentacaoViewModel : BaseViewModel
{
    private readonly IFirebaseAuthentication _auth;

    public ApresentacaoViewModel(IFirebaseAuthentication auth)
    {
        _auth = auth;

        Initialize();
    }

    private async void Initialize()
    {
        bool isLoggedIn = _auth.IsLoggedIn();
        if (isLoggedIn)
        {
            await Shell.Current.GoToAsync($"//{nameof(HomePage)}");
        }
    }

    [RelayCommand]
    async Task Login()
    {
        await Shell.Current.GoToAsync(nameof(LoginPage));
    }

    [RelayCommand]
    async Task Registrar()
    {
        await Shell.Current.GoToAsync(nameof(RegisterPage));
    }
}
