using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.Linq;
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
		IGetWeatherData data = Factory.CreateGetWeatherData;
		private readonly IGetCurrentLocation _locationService;
		public IRelayCommand GetDailyWeatherCommand { get; }
		public IRelayCommand GetCurrentWeatherCommand { get; }
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

		public WeatherViewModel()
		{
			_locationService = ServiceHelper.GetService<IGetCurrentLocation>();
			GetDailyWeatherCommand = new RelayCommand(GetDailyWeather);
			GetCurrentWeatherCommand = new RelayCommand(GetCurrentWeather);
		}
		private async void GetDailyWeather()
		{
			WeatherData = await data.GetWeatherForecastDailyAsync();
			int x = 2;
		}

		private async void GetCurrentWeather()
		{
			WeatherData = await data.GetWeatherForecastHourlyAsync();
			int x = 2;
		}


	}
}
