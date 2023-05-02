using project_gift_maui.ViewModels;

namespace project_gift_maui.Views;

public partial class RegisterPage : ContentPage
{
	public RegisterPage(RegisterViewModel viewModel)
	{
		InitializeComponent();
		BindingContext = viewModel;
	}
}