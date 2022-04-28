using OfflineCapable.Data;
using OfflineCapable.Models;

namespace OfflineCapable;

public partial class MainPage : ContentPage
{
    //int count = 0;

    private readonly InspectionsContext _context;

    public MainPage(InspectionsContext context)
    {
        InitializeComponent();
        _context = context;

        
    }

    private async void OnCounterClicked(object sender, EventArgs e)
    {
        //count++;
        //CounterLabel.Text = $"Current count: {count}";

        //SemanticScreenReader.Announce(CounterLabel.Text);

        var inspection = new Inspection { Title = "Test", StartDate = DateTime.Now };

        _context.Add(inspection);

        await _context.SaveChangesAsync();

        int count = _context.Inspections.Count();

        CounterLabel.Text = $"Current number of records: {count}";

    }
}

