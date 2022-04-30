using OfflineCapable.Data;
using OfflineCapable.Models;

namespace OfflineCapable;

public partial class LocalData : ContentPage
{
	private readonly IInspectionsRepository _repo;

	public LocalData(IInspectionsRepository repo)
	{
		InitializeComponent();
		_repo = repo;

		this.BindingContext = _repo.GetInspections();
	}
}