using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WeatherApiTester.Model.WeatherApiModels;
using WeatherApiTester.Model.WeatherApiModels.TommorowIO;

namespace WeatherApiTester.Services
{
    public interface IGetWeatherDataSvc
	{
		public Task<IWeatherCurrentModel> GetWeatherCurrentAsync();
	}
}
