using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeatherApiTester.Model.WeatherApiModels.TommorowIO
{
	public class WeatherModelTommorowIOForecast : WeatherModelTommorowIOBase
	{
		public Timelines timelines { get; set; }
		public Location location { get; set; }
		public class Hourly
		{
			public DateTime time { get; set; }
			public Values values { get; set; }
		}



		public class Timelines
		{
			public List<Hourly> hourly { get; set; }
		}
	}
}