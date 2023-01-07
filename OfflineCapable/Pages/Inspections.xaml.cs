using Microsoft.Extensions.Configuration;
using OfflineCapable.ViewModels;
using Windows.Media.Devices;

namespace OfflineCapable.Pages;

public partial class Inspections : ContentPage
{
	public Inspections(InspectionsViewModel viewModel)
	{
		InitializeComponent();

		BindingContext = viewModel;
	}
}