using OfflineCapable.Data;

namespace OfflineCapable;

public partial class App : Application
{
	public App()
	{
		InitializeComponent();

		MainPage = new AppShell();
	}
}
