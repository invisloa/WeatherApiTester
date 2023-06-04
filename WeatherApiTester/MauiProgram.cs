using Microsoft.Extensions.Logging;
using WeatherApiTester.Services;

namespace WeatherApiTester;

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

		builder.Services.AddSingleton<IGetCurrentLocation, LocationService>();
		builder.Services.AddSingleton<IGetWeatherData, WeatherServiceVisualCrossing>();
#if DEBUG
		builder.Logging.AddDebug();
#endif

		return builder.Build();
	}
}
