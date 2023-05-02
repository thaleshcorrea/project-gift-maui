using Firebase.Auth;
using Firebase.Auth.Providers;
using project_gift_maui.Models;
using project_gift_maui.Repositories.Auth;
using System.Diagnostics;

namespace project_gift_maui.Services;

public class FirebaseAuthentication : IFirebaseAuthentication
{
    private const string ApiKey = "AIzaSyCdHMt10njvjqScixPWCKrf5G2BNE_FPPQ";

    private static FirebaseAuthConfig _firebaseConfig;

    static FirebaseAuthClient CreateClient()
    {
        _firebaseConfig ??= new FirebaseAuthConfig
        {
            ApiKey = ApiKey,
            AuthDomain = "project-gift-9df0a.firebaseapp.com",
            Providers = new FirebaseAuthProvider[]
            {
                    new EmailProvider()
            },
            UserRepository = new UserRepository()
        };

        return new FirebaseAuthClient(_firebaseConfig);
    }

    public async Task<Usuario> LoginWithEmailAndPassword(string email, string password)
    {
        try
        {
            var client = CreateClient();
            var userCredential = await client.SignInWithEmailAndPasswordAsync(email, password);
            var usuario = new Usuario
            {
                UserId = userCredential.User.Uid,
                Email = userCredential.User.Info.Email,
                Token = userCredential.User.Credential.IdToken,
            };
            return usuario;
        }
        catch (Exception ex)
        {
            Debug.WriteLine(ex);
            return null;
        }
    }

    public async Task<bool> RegisterWithEmailAndPassword(string username, string email, string password)
    {
        try
        {
            var client = CreateClient();
            var userCredential = await client.CreateUserWithEmailAndPasswordAsync(email, password, username);
            return userCredential.User != null;
        }
        catch (Exception ex)
        {
            Debug.WriteLine(ex);
            return false;
        }
    }

    public async Task ForgetPassword(string email)
    {
        try
        {
            var client = CreateClient();
            await client.ResetEmailPasswordAsync(email);
        }
        catch (Exception ex)
        {
            Debug.WriteLine(ex);
        }
    }

    public string GetUserId()
    {
        var client = CreateClient();
        return client.User.Uid;
    }

    public string GetUsername()
    {
        var client = CreateClient();
        return client.User.Info.DisplayName;
    }

    public bool IsLoggedIn()
    {
        var client = CreateClient();
        return client.User != null;
    }

    public bool LogOut()
    {
        try
        {
            var client = CreateClient();
            client.SignOut();
            return true;
        }
        catch (Exception ex)
        {
            Debug.WriteLine(ex);
            return false;
        }
    }
}
