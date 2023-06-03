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
		private readonly LocationService _locationService;

		public WeatherViewModel(LocationService locationService)
		{
			_locationService = locationService;
		}
		async Task getWeatherDataFromApiAsync()
		{
			Location myCurrentLocation = await _locationService.GetCurrentLocationAsync();
		}


	}
}
