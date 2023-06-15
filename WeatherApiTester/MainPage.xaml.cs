using System.Diagnostics;
using System.Reflection;
using WeatherApiTester.Model.WeatherApiModels;
using WeatherApiTester.Services;
using WeatherApiTester.Services.WeatherServices;

namespace WeatherApiTester;

public partial class MainPage : ContentPage
{
	int count = 0;

	public MainPage()
	{
		InitializeComponent();
	}
	private async void OnCounterClicked(object sender, EventArgs e)
	{
		IWeatherCurrentModel model ;
		IGetWeatherDataSvc data = Factory.CreateGetWeatherData;
		model = await data.GetWeatherCurrentAsync();
		int x = 2;
	}


}

