using CommunityToolkit.Mvvm.ComponentModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WeatherApiTester.Model;
using WeatherApiTester.Services;

namespace WeatherApiTester.ViewModel
{
	public partial class WeatherViewModel : ObservableObject
	{
 		private WeatherModel _weatherData;
		public WeatherModel WeatherData 
		{ get => _weatherData;
			set
			{
				if (_weatherData != value) 
				{
				_weatherData = value;
				OnPropertyChanged();
				}
			}
		}
		public WeatherViewModel()
		{

		}
		async Task getWeatherDataFromApiAsync()
		{
		LocationService location = new LocationService();
		PermissionStatus status = await Permissions.CheckStatusAsync<Permissions.LocationWhenInUse>();
		status = await Permissions.RequestAsync<Permissions.LocationWhenInUse>();
		status = await CheckAndRequestLocationPermission();
		Location newLocation = await location.GetCurrentLocationAsync();
		count++;

		if (count == 1)
			CounterBtn.Text = $"Clicked {newLocation.ToString()} time";
		else
			CounterBtn.Text = $"Clicked time";

		SemanticScreenReader.Announce(CounterBtn.Text);*/
		}
	}
}
