using Microsoft.Extensions.Configuration;
using OfflineCapable.Data;
using OfflineCapable.Models;
using System.Net.Http.Json;

namespace OfflineCapable;

public partial class MainPage : ContentPage
{
    private readonly IInspectionsRepository _repo;

    public MainPage(IInspectionsRepository repo, IConfiguration config)
    {
        InitializeComponent();
        _repo = repo;

        ConfigurationSettings.serviceClientUrl = config["serviceClientUrl"];
        ConfigurationSettings.clientId = config["clientId"];
        ConfigurationSettings.clientSecret = config["clientSecret"];
        ConfigurationSettings.loginUrl = config["loginUrl"];       
    }

    //load local data page
    private void LocalDataView_Clicked(object sender, EventArgs e)
    {
        Navigation.PushAsync(new LocalData(_repo));
    }
}

