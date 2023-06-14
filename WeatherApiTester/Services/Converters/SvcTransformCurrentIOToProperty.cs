using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WeatherApiTester.Model.WeatherApiModels;
using WeatherApiTester.Model.WeatherApiModels.TommorowIO;

namespace WeatherApiTester.Services.Converters
{
	internal class SvcTransformCurrentIOToProperty
	{
		// This method assumes that you have some way of getting the raw weather data.
		public WeatherModelTommorowIODailyForecast GetRawWeatherData()
		{
			// Retrieve and return the raw weather data.
		}

		public List<WeatherProperty> ExtractWeatherProperties(WeatherModelTommorowIODailyForecast weatherData)
		{
			var weatherProperties = new List<WeatherProperty>();

			// Extract Location fields
			weatherProperties.AddRange(weatherData.ExtractLocationFields());

			// Extract Timeline fields
			weatherProperties.AddRange(weatherData.ExtractTimelinesFields());

			return weatherProperties;
		}
	}
}
