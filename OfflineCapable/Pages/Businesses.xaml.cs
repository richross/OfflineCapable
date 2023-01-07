using OfflineCapable.ViewModels;

namespace OfflineCapable.Pages;

public partial class Businesses : ContentPage
{
	public Businesses(BusinessesViewModel viewmodel)
	{
		InitializeComponent();

		BindingContext = viewmodel;
	}
}