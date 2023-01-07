using OfflineCapable.Pages;

namespace OfflineCapable;

public partial class AppShell : Shell
{
    public AppShell()
    {
        InitializeComponent();

        Routing.RegisterRoute(nameof(Inspections), typeof(Inspections));
    }
}
