﻿using CommunityToolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WeatherApiTester.Model.WeatherApiModels;
using WeatherApiTester.Services;
using WeatherApiTester.Services.Converters;
using WeatherApiTester.ViewModel.TommoroIO;

namespace WeatherApiTester.ViewModel
{
	class WeatherCurrentTIO_VM : BaseWeatherViewModel
	{

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