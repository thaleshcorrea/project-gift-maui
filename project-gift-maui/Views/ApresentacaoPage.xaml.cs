using project_gift_maui.ViewModels;

namespace project_gift_maui.Views;

public partial class ApresentacaoPage : ContentPage
{
	public ApresentacaoPage(ApresentacaoViewModel viewModel)
	{
		InitializeComponent();
		BindingContext = viewModel;
	}
}