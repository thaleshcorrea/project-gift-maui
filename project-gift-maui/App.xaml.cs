using project_gift_maui.Views;

namespace project_gift_maui;

public partial class App : Application
{
    public App()
    {
        InitializeComponent();

        MainPage = new AppShell();
    }
}
