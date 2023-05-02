using project_gift_maui.Models;

namespace project_gift_maui.Services;

public interface IFirebaseAuthentication
{
    Task<Usuario> LoginWithEmailAndPassword(string email, string password);
    Task<bool> RegisterWithEmailAndPassword(string username, string email, string password);
    Task ForgetPassword(string email);
    string GetUsername();
    string GetUserId();
    bool IsLoggedIn();
    bool LogOut();
}
