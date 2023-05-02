using project_gift_maui.ViewModels;

namespace project_gift_maui.Views;

public partial class PerfilPage : ContentPage
{
	public PerfilPage(PerfilViewModel viewModel)
	{
		InitializeComponent();
		BindingContext = viewModel;
	}
}