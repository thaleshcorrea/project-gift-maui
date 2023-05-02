using CommunityToolkit.Maui.Alerts;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using project_gift_maui.Services;
using project_gift_maui.Views;

namespace project_gift_maui.ViewModels;

public partial class RegisterViewModel : BaseViewModel
{
    [ObservableProperty]
    string nome;

    [ObservableProperty]
    string email;

    [ObservableProperty]
    string senha;

    [ObservableProperty]
    string confirmacaoSenha;

    private readonly IFirebaseAuthentication _auth;
    public RegisterViewModel(IFirebaseAuthentication auth)
    {
        _auth = auth;
    }

    [RelayCommand]
    async Task Registrar()
    {
        bool sucesso = await _auth.RegisterWithEmailAndPassword(Nome, Email, Senha);
        if (sucesso)
        {
            await Shell.Current.GoToAsync($"//{nameof(LoginPage)}");
        }

        var snackbar = Snackbar.Make("Ocorreu um erro ao registrar usuário", duration: TimeSpan.FromSeconds(5));
        await snackbar.Show();
    }
}
