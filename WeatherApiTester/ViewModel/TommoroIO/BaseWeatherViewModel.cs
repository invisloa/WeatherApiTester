using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WeatherApiTester.Model.WeatherApiModels;
using WeatherApiTester.Services;

namespace WeatherApiTester.ViewModel.TommoroIO
{
	public abstract class BaseWeatherViewModel : BaseViewModel
	{

		protected Dictionary<string, string> _weatherProperties = new Dictionary<string, string>();
		protected IWeatherCurrentModel _weatherDataModel;
		protected IGetWeatherDataSvc data = Factory.CreateGetWeatherData;

	}
}
