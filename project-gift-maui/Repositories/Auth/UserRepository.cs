using Firebase.Auth;
using Firebase.Auth.Repository;
using Newtonsoft.Json;

namespace project_gift_maui.Repositories.Auth;

public class UserRepository : IUserRepository
{
    private const string UserInfo = nameof(UserInfo);
    private const string AccessToken = nameof(AccessToken);

    public void DeleteUser()
    {
        Preferences.Remove(UserInfo);
        Preferences.Remove(AccessToken);
    }

    public (UserInfo userInfo, FirebaseCredential credential) ReadUser()
    {
        var userSerialized = Preferences.Get(UserInfo, null);
        var credentialSerialized = Preferences.Get(AccessToken, null);
        var userInfo = JsonConvert.DeserializeObject<UserInfo>(userSerialized);
        var credential = JsonConvert.DeserializeObject<FirebaseCredential>(credentialSerialized);

        return (userInfo, credential);
    }

    public void SaveUser(User user)
    {
        var userSerialized = JsonConvert.SerializeObject(user.Info);
        var credentialSerialized = JsonConvert.SerializeObject(user.Credential);
        Preferences.Set(UserInfo, userSerialized);
        Preferences.Set(AccessToken, credentialSerialized);
    }

    public bool UserExists()
    {
        return Preferences.ContainsKey(UserInfo);
    }
}
