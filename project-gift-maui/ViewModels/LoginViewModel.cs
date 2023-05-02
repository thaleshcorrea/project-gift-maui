using CommunityToolkit.Maui.Alerts;
using CommunityToolkit.Mvvm.Input;
using project_gift_maui.Services;
using project_gift_maui.Views;
using System.ComponentModel.DataAnnotations;

namespace project_gift_maui.ViewModels;

public partial class LoginViewModel : BaseViewModel
{
    string email;
    string senha;

    [EmailAddress(ErrorMessage = "Email inválido")]
    [Required]
    public string Email
    {
        get => email;
        set => SetProperty(ref email, value, validate: true);
    }

    [MinLength(6, ErrorMessage = "A senha deve possuir ao menos 6 caracteres")]
    [Required]
    public string Senha
    {
        get => senha;
        set => SetProperty(ref senha, value, validate: true);
    }

    private readonly IFirebaseAuthentication _auth;
    public LoginViewModel(IFirebaseAuthentication auth)
    {
        _auth = auth;
    }

    [RelayCommand]
    async Task Login()
    {
        ValidateAllProperties();
        if (HasErrors)
        {
            return;
        }

        var usuario = await _auth.LoginWithEmailAndPassword(Email, Senha);
        if (usuario == null)
        {
            var snackbar = Snackbar.Make("Usuário ou senha inválidos.", duration: TimeSpan.FromSeconds(5));
            await snackbar.Show();
        }

        await Shell.Current.GoToAsync($"//{nameof(HomePage)}");
    }

    [RelayCommand]
    async Task Registrar()
    {
        await Shell.Current.GoToAsync(nameof(RegisterPage));
    }
}
