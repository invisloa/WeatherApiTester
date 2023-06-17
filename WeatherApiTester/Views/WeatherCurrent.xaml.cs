using WeatherApiTester.Services;
using WeatherApiTester.Services.WeatherServices;

namespace WeatherApiTester.Views;

public partial class WeatherCurrent : ContentPage
{
	public WeatherCurrent()
	{
		var viewModel = new WeatherApiTester.ViewModel.WeatherCurrentTIO_VM();
		IGetWeatherDataSvc _currentWeatherService = Factory.GetCurrentWeatherService;
		viewModel.WeatherData =   _currentWeatherService.GetWeatherCurrentAsync().Result;
		InitializeComponent();
		BindingContext = viewModel;

	}
}