using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeatherApiTester.Model.WeatherApiModels.TommorowIO
{
	public abstract class WeatherModelTommorowIOBase : IWeatherModel
	{
		public class Location
		{
			public double lat { get; set; }
			public double lon { get; set; }
			public string name { get; set; }
			public string type { get; set; }
		}

	}
}