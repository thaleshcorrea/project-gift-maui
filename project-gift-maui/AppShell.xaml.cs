using project_gift_maui.Views;

namespace project_gift_maui;

public partial class AppShell : Shell
{
	public AppShell()
	{
		InitializeComponent();
		RegisterRoutes();
	}

	private static void RegisterRoutes()
	{
        Routing.RegisterRoute(nameof(LoginPage), typeof(LoginPage));
        Routing.RegisterRoute(nameof(RegisterPage), typeof(RegisterPage));
		Routing.RegisterRoute(nameof(PerfilPage), typeof(PerfilPage));
	}
}
