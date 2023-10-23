using Microsoft.Extensions.Logging;
using ApiExample2.Services;
namespace ApiExample2;

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
			builder.Services.AddSingleton<IMangaTop,MangaTop>();
			builder.Services.AddTransient<MainPage> ();

#if DEBUG
		builder.Logging.AddDebug();
#endif

		return builder.Build();
	}
}
