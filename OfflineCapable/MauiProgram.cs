using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using OfflineCapable.Data;
using OfflineCapable.Models;
using System.Reflection;

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

		//needed to see the injection of the dbcontext
		builder.Services.AddSingleton<MainPage>();
		builder.Services.AddSingleton<IInspectionsRepository, InspectionsRepository>();

		builder.Configuration.AddUserSecrets(Assembly.GetExecutingAssembly(), true);

        return builder.Build();

	}

}