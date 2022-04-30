using OfflineCapable.Data;
using OfflineCapable.Models;
using System.Net.Http.Json;

namespace OfflineCapable;

public partial class Dataverse : ContentPage
{
	public Dataverse()
	{
		InitializeComponent();

        var dataverse = new DataverseContext();

        //call the web api and get the http response
        HttpResponseMessage inspections = dataverse.GetInspections().Result;

        //convert the json response into the page view object.
        InspectionsPwrPlt inspectionsView = inspections.Content.ReadFromJsonAsync<InspectionsPwrPlt>().Result;

        //load the object into the binding context
        this.BindingContext = inspectionsView; 
    }

    private void Back_Clicked(object sender, EventArgs e)
    {
		Navigation.PopAsync(false);
    }
}