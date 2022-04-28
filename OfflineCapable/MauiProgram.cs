using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using OfflineCapable.Data;

namespace OfflineCapable;

public static class MauiProgram
{
	public static MauiApp CreateMauiApp()
	{
		var builder = MauiApp.CreateBuilder();
		builder
			.UseMauiApp<App>()
			.ConfigureFonts(fonts =>
			{
				fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
				fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
			});

		//defines the physical location of the database
		string dbPath = Path.Combine(FileSystem.AppDataDirectory, "inspections.db3");

		builder.Services.AddDbContext<InspectionsContext>(
            options => options.UseSqlite($"Filename={dbPath}"));

		builder.Services.AddSingleton<MainPage>();

        return builder.Build();

	}

}