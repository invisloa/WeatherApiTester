using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WeatherApiTester.Model;

namespace WeatherApiTester.Services
{
    public interface IGetWeatherData
    {
		public Task<IWeatherModel> GetWeather15DaysAsync();


	}
}
