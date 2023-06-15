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
		public WeatherProperty Location { get => WeatherData.LocationName; set { } }
		public WeatherProperty Time { get => WeatherData.Time; set { } }
		public WeatherProperty Temperature { get => WeatherData.Temperature; set { } }
		public WeatherProperty TemperatureApparent { get => WeatherData.TemperatureApparent; set { } }
		public WeatherProperty WeatherCode { get => WeatherData.WeatherCode; set { } }
		public WeatherProperty PrecipitationProbability { get => WeatherData.PrecipitationProbability; set { } }
		public WeatherProperty RainIntensity { get => WeatherData.RainIntensity; set { } }
		public WeatherProperty SleetIntensity { get => WeatherData.SleetIntensity; set { } }
		public WeatherProperty SnowIntensity { get => WeatherData.SnowIntensity; set { } }
		public WeatherProperty FreezingRainIntensity { get => WeatherData.FreezingRainIntensity; set { } }
		public WeatherProperty WindSpeed { get => WeatherData.WindSpeed; set { } }
		public WeatherProperty PressureSurfaceLevel { get => WeatherData.PressureSurfaceLevel; set { } }
		#endregion


		public ObservableCollection<string> SomeList { get; set; }

		public WeatherCurrentTIO_VM()
		{
			GetCurrentWeatherCommand = new RelayCommand(GetCurrentWeather);
			GetCurrentWeather();                                                    // get weather _dataService at construction phase
		}
		private async void GetCurrentWeather()
		{
			WeatherData = await _dataService.GetWeatherCurrentAsync();
			setProperties();
		}
	private void setProperties()
		{
			Time.Value = WeatherData.Time.Value;
			Temperature.Value = WeatherData.Temperature.Value;
			TemperatureApparent.Value = WeatherData.TemperatureApparent.Value;
			WeatherCode.Value = WeatherData.WeatherCode.Value;
			PrecipitationProbability.Value = WeatherData.PrecipitationProbability.Value;
			RainIntensity.Value = WeatherData.RainIntensity.Value;
			SleetIntensity.Value = WeatherData.SleetIntensity.Value;
			SnowIntensity.Value = WeatherData.SnowIntensity.Value;
			FreezingRainIntensity.Value = WeatherData.FreezingRainIntensity.Value;
			WindSpeed.Value = WeatherData.WindSpeed.Value;
			PressureSurfaceLevel.Value = WeatherData.PressureSurfaceLevel.Value;
		}
	}
}