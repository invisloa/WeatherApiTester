using CommunityToolkit.Mvvm.ComponentModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WeatherApiTester.Model;
using WeatherApiTester.Services;
using Location = Microsoft.Maui.Devices.Sensors.Location;

namespace WeatherApiTester.ViewModel
{
	public partial class WeatherViewModel : ObservableObject
	{
 		private IWeatherModel _weatherData;
		public IWeatherModel WeatherData 
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
		private readonly IGetCurrentLocation _locationService;

		public WeatherViewModel(IGetCurrentLocation locationService)
		{
			_locationService = locationService;
		}

		async Task getWeatherDataFromApiAsync()
		{
			Location myCurrentLocation = await _locationService.GetCurrentLocationAsync();
		}

/*		void someMethod()
		{
			var weatherData = GetWeatherData();  // Retrieve from API
			var userPreferences = GetUserPreferences(); // Retrieve from storage

			foreach (var preference in userPreferences.OrderedPreferences)
			{
				var value = GetPropertyValue(weatherData, preference.PropertyName);
				AddToView(preference.PropertyName, value);
			}
		}
*/		private object GetPropertyValue(object obj, string propertyName)
		{
			var propertyInfo = obj.GetType().GetProperty(propertyName);
			return propertyInfo?.GetValue(obj, null);
		}


	}
}
