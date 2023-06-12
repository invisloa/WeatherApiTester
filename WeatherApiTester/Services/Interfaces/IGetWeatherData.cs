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
		public Task<IWeatherCurrentModel> GetWeatherForecastDailyAsync();
		public Task<IWeatherCurrentModel> GetWeatherForecastHourlyAsync();
		public Task<IWeatherCurrentModel> GetWeatherCurrentAsync();
		public Task<IWeatherCurrentModel> GetWeatherHistoricAsync();


	}
}
