using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeatherApiTester.Model.WeatherApiModels.TommorowIO
{
    public class WeatherModelTommorowIOCurrent : WeatherModelTommorowIOBase

	{


		public Data data { get; set; }
        public Location location { get; set; }
        public class Data
        {
            public DateTime time { get; set; }
            public Values values { get; set; }
        }
		public class Values
		{
			public double cloudBase { get; set; }
			public double cloudCeiling { get; set; }
			public int cloudCover { get; set; }
			public double dewPoint { get; set; }
			public int freezingRainIntensity { get; set; }
			public int humidity { get; set; }
			public int precipitationProbability { get; set; }
			public double pressureSurfaceLevel { get; set; }
			public int rainIntensity { get; set; }
			public int sleetIntensity { get; set; }
			public int snowIntensity { get; set; }
			public double temperature { get; set; }
			public double temperatureApparent { get; set; }
			public int uvHealthConcern { get; set; }
			public int uvIndex { get; set; }	//0-2: Low	3-5: Moderate	6-7: High	8-10: Very High		11+: Extreme
			public double visibility { get; set; }
			public int weatherCode { get; set; }
			public double windDirection { get; set; }
			public double windGust { get; set; }
			public double windSpeed { get; set; }
		}

	}
}