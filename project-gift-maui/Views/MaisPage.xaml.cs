using project_gift_maui.ViewModels;

namespace project_gift_maui.Views;

public partial class MaisPage : ContentPage
{
	public MaisPage(MaisViewModel viewModel)
	{
		InitializeComponent();
		BindingContext = viewModel;
	}
}