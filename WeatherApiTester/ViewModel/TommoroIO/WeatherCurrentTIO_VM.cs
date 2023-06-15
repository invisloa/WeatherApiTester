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
		private WeatherProperty location;

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
		public WeatherProperty Location
		{
			get => location;
			set
			{
				if (location != value)
				{
					location = value;
					OnPropertyChanged();
				}
			}
		}
		public WeatherProperty Time { get; set; }
		public WeatherProperty Temperature { get; set; }
		public WeatherProperty TemperatureAparent { get; set; }
		public WeatherProperty WeatherCode { get; set; }
		public WeatherProperty PrecipitationProbability { get; set; }
		public WeatherProperty RainIntensity { get; set; }
		public WeatherProperty SleetIntensity { get; set; }
		public WeatherProperty SnowIntensity { get; set; }
		public WeatherProperty FreezingRainIntensity { get; set; }
		public WeatherProperty WindSpeed { get; set; }
		public WeatherProperty PressureSurfaceLevel { get; set; }
		#endregion


		public ObservableCollection<string> SomeList { get; set; }

		public WeatherCurrentTIO_VM()
		{
			GetCurrentWeatherCommand = new RelayCommand(GetCurrentWeather);
			GetCurrentWeather();                                                    // get weather _dataService at construction phase
			Time = WeatherData.Time;
			Temperature = WeatherData.Temperature;
			TemperatureAparent = WeatherData.TemperatureAparent;
			WeatherCode = WeatherData.WeatherCode;
			PrecipitationProbability = WeatherData.PrecipitationProbability;
			RainIntensity = WeatherData.RainIntensity;
			SleetIntensity = WeatherData.SleetIntensity;
			SnowIntensity = WeatherData.SnowIntensity;
			FreezingRainIntensity = WeatherData.FreezingRainIntensity;
			WindSpeed = WeatherData.WindSpeed;
			PressureSurfaceLevel = WeatherData.PressureSurfaceLevel;

		}
		private async void GetCurrentWeather()
		{
			WeatherData = await _dataService.GetWeatherCurrentAsync();
		}

	}
}