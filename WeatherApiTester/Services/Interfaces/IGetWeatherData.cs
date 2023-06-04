using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WeatherApiTester.Model.WeatherApiModels;

namespace WeatherApiTester.Services
{
    public interface IGetWeatherData
	{
		public Task<IWeatherModel> GetWeatherForecastDailyAsync();
		public Task<IWeatherModel> GetWeatherForecastHourlyAsync();
		public Task<IWeatherModel> GetWeatherCurrentAsync();
		public Task<IWeatherModel> GetWeatherHistoricAsync();


	}
}
