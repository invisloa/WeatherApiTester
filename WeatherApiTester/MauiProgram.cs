using Microsoft.Extensions.Logging;
using WeatherApiTester.Services;
using WeatherApiTester.Services.WeatherServices;
using WeatherApiTester.ViewModel;
using static WeatherApiTester.ViewModel.WeatherCurrentTIO_VM;

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
		builder.Services.AddSingleton<WeatherCurrentTIO_VM>();
		builder.Services.AddSingleton<IGetWeatherDataSvc, WeatherServiceVisualCrossing>();
#if DEBUG
		builder.Logging.AddDebug();
#endif

		return builder.Build();
	}
}
