using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using WeatherApiTester.Helpers;
using WeatherApiTester.Model.WeatherApiModels;
using WeatherApiTester.Services;
using Location = Microsoft.Maui.Devices.Sensors.Location;

namespace WeatherApiTester.ViewModel
{
    public partial class WeatherViewModel : BaseViewModel
	{
 		private IWeatherModel _weatherData;
		private Dictionary<string, string> _weatherProperties = new Dictionary<string, string>();
		IGetWeatherData data = Factory.CreateGetWeatherData;
		private readonly IGetCurrentLocation _locationService;
		public IRelayCommand GetDailyWeatherCommand { get; }
		public IRelayCommand GetCurrentWeatherCommand { get; }

		public IWeatherModel WeatherData
		{
			get => _weatherData;
			set
			{
				if (_weatherData != value)
				{
					_weatherData = value;
					GetWeatherPropertiesToDictionary();
					OnPropertyChanged();
				}
			}
		}
		public Dictionary<string, string> WeatherPropertiesDictionary
		{
			get => _weatherProperties;
			set
			{
				if (_weatherProperties != value)
				{
					_weatherProperties = value;
					OnPropertyChanged();
				}
			}
		}
		
		private void GetWeatherPropertiesToDictionary()
		{
			foreach (PropertyInfo prop in _weatherData.GetType().GetProperties())
			{
				object value = prop.GetValue(_weatherData, null);
				string valueStr = value != null ? value.ToString() : null;
				WeatherPropertiesDictionary.Add(prop.Name, valueStr);
			}
		}
		public ObservableCollection<string> SomeList { get; set; }

		public WeatherViewModel()
		{
			_locationService = ServiceHelper.GetService<IGetCurrentLocation>();
			GetDailyWeatherCommand = new RelayCommand(GetDailyWeather);
			GetCurrentWeatherCommand = new RelayCommand(GetCurrentWeather);

		}
		private async void GetDailyWeather()
		{
			WeatherData = await data.GetWeatherForecastDailyAsync();
		}

		private async void GetCurrentWeather()
		{
			WeatherData = await data.GetWeatherForecastHourlyAsync();
		}


	}
}
