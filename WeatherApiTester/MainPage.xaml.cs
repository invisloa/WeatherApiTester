using System.Diagnostics;
using System.Reflection;
using WeatherApiTester.Model;
using WeatherApiTester.Services;

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
		WeatherModel model;
		WeatherService weatherService = new WeatherService();
		model = await weatherService.GetWeather15DaysAsync();
		int x = 2;
	}
}

