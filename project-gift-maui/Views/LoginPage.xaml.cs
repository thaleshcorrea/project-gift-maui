using project_gift_maui.ViewModels;

namespace project_gift_maui.Views;

public partial class LoginPage : ContentPage
{
	public LoginPage(LoginViewModel viewModel)
	{
		InitializeComponent();
		BindingContext = viewModel;
	}
}