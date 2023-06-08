using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeatherApiTester.Model.WeatherApiModels.TommorowIO
{
	public class WeatherModelTommorowIOHourlyForecast : WeatherModelTommorowIOBase
	{
		public Timelines timelines { get; set; }
		public Location location { get; set; }
		// Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse);
		public class Hourly
		{
			public DateTime time { get; set; }
			public Values values { get; set; }
		}


		public class Timelines
		{
			public List<Hourly> hourly { get; set; }
		}

		public class Values
		{
			public double? cloudBase { get; set; }
			public double? cloudCeiling { get; set; }
			public double cloudCover { get; set; }
			public double dewPoint { get; set; }
			public double evapotranspiration { get; set; }
			public int freezingRainIntensity { get; set; }
			public double humidity { get; set; }
			public int iceAccumulation { get; set; }
			public int iceAccumulationLwe { get; set; }
			public int precipitationProbability { get; set; }
			public double pressureSurfaceLevel { get; set; }
			public int rainAccumulation { get; set; }
			public int rainAccumulationLwe { get; set; }
			public int rainIntensity { get; set; }
			public int sleetAccumulation { get; set; }
			public int sleetAccumulationLwe { get; set; }
			public int sleetIntensity { get; set; }
			public int snowAccumulation { get; set; }
			public int snowAccumulationLwe { get; set; }
			public int snowDepth { get; set; }
			public int snowIntensity { get; set; }
			public double temperature { get; set; }
			public double temperatureApparent { get; set; }
			public int uvHealthConcern { get; set; }
			public int uvIndex { get; set; }
			public double visibility { get; set; }
			public int weatherCode { get; set; }
			public double windDirection { get; set; }
			public double windGust { get; set; }
			public double windSpeed { get; set; }
		}

	}
}