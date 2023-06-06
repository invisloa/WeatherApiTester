using CommunityToolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WeatherApiTester.Model.WeatherApiModels;
using WeatherApiTester.Services;
using WeatherApiTester.Services.Converters;

namespace WeatherApiTester.ViewModel
{
    class WeatherCurrentViewModel
    {

		public partial class WeatherViewModel : BaseViewModel
		{
			private Dictionary<string, string> _weatherProperties = new Dictionary<string, string>();
			private IWeatherModel _weatherData;
			IGetWeatherData data = Factory.CreateGetWeatherData;
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
				WeatherPropertiesDictionary = WeatherModelToDictionary.ObjectToDictionary(WeatherData, "");
			}
			public ObservableCollection<string> SomeList { get; set; }

			public WeatherViewModel()
			{
				GetCurrentWeatherCommand = new RelayCommand(GetCurrentWeather);

			}
			private async void GetCurrentWeather()
			{
				WeatherData = await data.GetWeatherCurrentAsync();
			}


		}


















	}
}
