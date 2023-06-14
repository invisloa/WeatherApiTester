using CommunityToolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WeatherApiTester.Model.WeatherApiModels;
using WeatherApiTester.Services;
using WeatherApiTester.ViewModel.TommoroIO;

namespace WeatherApiTester.ViewModel
{
	class WeatherCurrentTIO_VM : BaseWeatherViewModel
	{
		public IRelayCommand GetCurrentWeatherCommand { get; }
		public IWeatherCurrentModel WeatherData
		{
			get => _weatherDataModel;
			set
			{
				if (_weatherDataModel != value)
				{
					_weatherDataModel = value;
					OnPropertyChanged();
				}
			}
		}
		#region Primary Data
		public WeatherProperty Location { get; set; }
		public WeatherProperty Time { get; set; }
		public WeatherProperty Temperature { get; set; }
		public WeatherProperty TemperatureAparent { get; set; }
		public WeatherProperty WeatherCode { get; set; }
		public WeatherProperty PrecipitationProbability { get; set; }
		public WeatherProperty RainIntensity { get; set; }
		public WeatherProperty SleetIntensity { get; set; }
		public WeatherProperty SnowIntensity { get; set; }
		public WeatherProperty FreezingRainIntensity { get; set; }
		public WeatherProperty windSpeed { get; set; }
		public WeatherProperty PressureSurfaceLevel { get; set; }
		#endregion


		public ObservableCollection<string> SomeList { get; set; }

		public WeatherCurrentTIO_VM()
		{
			GetCurrentWeatherCommand = new RelayCommand(GetCurrentWeather);			
		}
		private async void GetCurrentWeather()
		{
			WeatherData = await data.GetWeatherCurrentAsync();						
		}

	}
}