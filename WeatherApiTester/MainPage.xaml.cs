using System.Diagnostics;
using System.Reflection;
using WeatherApiTester.Model;
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
		IWeatherModel model ;
		IGetWeatherData data = Factory.CreateGetWeatherData;
		model = await data.GetWeatherCurrentAsync();
		int x = 2;
	}


}

