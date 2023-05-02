using CommunityToolkit.Maui.Converters;
using CommunityToolkit.Mvvm.ComponentModel;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace project_gift_maui.ViewModels;

public abstract class BaseViewModel : ObservableValidator
{
    #region Private & Protected

    #endregion

    #region Properties

    public string Title { get; set; }
    public LayoutState MainState { get; set; }
    public bool HasNoInternetConnection { get; set; }

    #endregion

    #region Constructor

    public BaseViewModel()
    {
        Connectivity.ConnectivityChanged += ConnectivityChanged;
        HasNoInternetConnection = !Connectivity.NetworkAccess.Equals(NetworkAccess.Internet);
    }

    #endregion

    #region Internet Connection

    private void ConnectivityChanged(object sender, ConnectivityChangedEventArgs e)
    {
        HasNoInternetConnection = !e.NetworkAccess.Equals(NetworkAccess.Internet);
    }

    #endregion
}
