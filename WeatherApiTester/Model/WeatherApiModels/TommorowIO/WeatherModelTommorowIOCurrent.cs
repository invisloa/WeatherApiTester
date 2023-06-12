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
			public int uvIndex { get; set; }
			public double visibility { get; set; }
			public int weatherCode { get; set; }
			public double windDirection { get; set; }
			public double windGust { get; set; }
			public double windSpeed { get; set; }
		}


		public Dictionary<string, object> ExtractData()
		{
			var dataDict = new Dictionary<string, object>
			{
				{"time", data.time},
				{"values", data.values}
			};
			return dataDict;
		}

		public Dictionary<string, object> ExtractLocation()
		{
			var locationDict = new Dictionary<string, object>
			{
			{"lat", location.lat},
			{"lon", location.lon},
			{"name", location.name},
			{"type", location.type}
		};
			return locationDict;
		}

		public Dictionary<string, object> ExtractValues()
		{
			var valuesDict = new Dictionary<string, object>
			{
				{"cloudBase", data.values.cloudBase},
				{"cloudCeiling", data.values.cloudCeiling},
				{"cloudCover", data.values.cloudCover},
				{"dewPoint", data.values.dewPoint},
				{"freezingRainIntensity", data.values.freezingRainIntensity},
				{"humidity", data.values.humidity},
				{"precipitationProbability", data.values.precipitationProbability},
				{"pressureSurfaceLevel", data.values.pressureSurfaceLevel},
				{"rainIntensity", data.values.rainIntensity},
				{"sleetIntensity", data.values.sleetIntensity},
				{"snowIntensity", data.values.snowIntensity},
				{"temperature", data.values.temperature},
				{"temperatureApparent", data.values.temperatureApparent},
				{"uvHealthConcern", data.values.uvHealthConcern},
				{"uvIndex", data.values.uvIndex},
				{"visibility", data.values.visibility},
				{"weatherCode", data.values.weatherCode},
				{"windDirection", data.values.windDirection},
				{"windGust", data.values.windGust},
				{"windSpeed", data.values.windSpeed}
			};
			return valuesDict;
		}
	}
}