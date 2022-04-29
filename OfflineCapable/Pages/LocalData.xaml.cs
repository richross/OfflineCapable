using OfflineCapable.Data;

namespace OfflineCapable;

public partial class LocalData : ContentPage
{
	private readonly InspectionsContext _context;

	public LocalData(InspectionsContext context)
	{
		InitializeComponent();
		_context = context;

		this.BindingContext = _context;
	}

    private void Back_Clicked(object sender, EventArgs e)
    {
		Navigation.PopAsync(false);
    }
}