using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WeatherApiTester.Model.WeatherApiModels.TommorowIO;
using WeatherApiTester.Services.WeatherServices;

namespace WeatherApiTester.Services
{
	public static class Factory
	{
		public static WeatherModelTommorowIOCurrent CreateGetWeatherData => new WeatherServiceTommorowIO();
	}
}
