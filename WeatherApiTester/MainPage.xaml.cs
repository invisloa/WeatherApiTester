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
		WeatherModelVisualCrossing model;
		WeatherServiceVisualCrossing weatherService = new WeatherServiceVisualCrossing();
		model = await weatherService.GetWeather15DaysAsync();
		int x = 2;
	}
}

