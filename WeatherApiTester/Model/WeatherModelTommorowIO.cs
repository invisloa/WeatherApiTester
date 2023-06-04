/*using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeatherApiTester.Model
{
	internal class WeatherModelTommorowIO : IWeatherModel
	{
		public Timelines timelines { get; set; }
		public Location location { get; set; }
	}

	public class Daily
	{
		public DateTime time { get; set; }
		public Values values { get; set; }
	}

	public class Hourly
	{
		public DateTime time { get; set; }
		public Values values { get; set; }
	}

	public class Location
	{
		public double lat { get; set; }
		public double lon { get; set; }
		public string name { get; set; }
		public string type { get; set; }
	}

	public class Minutely
	{
		public DateTime time { get; set; }
		public Values values { get; set; }
	}


	public class Timelines
	{
		public List<Minutely> minutely { get; set; }
		public List<Hourly> hourly { get; set; }
		public List<Daily> daily { get; set; }
	}

	public class Values
	{
		public double cloudBase { get; set; }
		public double cloudCeiling { get; set; }
		public double cloudCover { get; set; }
		public double dewPoint { get; set; }
		public int freezingRainIntensity { get; set; }
		public double humidity { get; set; }
		public int precipitationProbability { get; set; }
		public double pressureSurfaceLevel { get; set; }
		public double rainIntensity { get; set; }
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
		public double evapotranspiration { get; set; }
		public int iceAccumulation { get; set; }
		public int iceAccumulationLwe { get; set; }
		public double rainAccumulation { get; set; }
		public double rainAccumulationLwe { get; set; }
		public int sleetAccumulation { get; set; }
		public int sleetAccumulationLwe { get; set; }
		public int snowAccumulation { get; set; }
		public int snowAccumulationLwe { get; set; }
		public double cloudBaseAvg { get; set; }
		public double cloudBaseMax { get; set; }
		public double cloudBaseMin { get; set; }
		public double cloudCeilingAvg { get; set; }
		public double cloudCeilingMax { get; set; }
		public double cloudCeilingMin { get; set; }
		public double cloudCoverAvg { get; set; }
		public int cloudCoverMax { get; set; }
		public double cloudCoverMin { get; set; }
		public double dewPointAvg { get; set; }
		public double dewPointMax { get; set; }
		public double dewPointMin { get; set; }
		public double evapotranspirationAvg { get; set; }
		public double evapotranspirationMax { get; set; }
		public double evapotranspirationMin { get; set; }
		public double evapotranspirationSum { get; set; }
		public int freezingRainIntensityAvg { get; set; }
		public int freezingRainIntensityMax { get; set; }
		public int freezingRainIntensityMin { get; set; }
		public double humidityAvg { get; set; }
		public double humidityMax { get; set; }
		public double humidityMin { get; set; }
		public int iceAccumulationAvg { get; set; }
		public int iceAccumulationLweAvg { get; set; }
		public int iceAccumulationLweMax { get; set; }
		public int iceAccumulationLweMin { get; set; }
		public int iceAccumulationLweSum { get; set; }
		public int iceAccumulationMax { get; set; }
		public int iceAccumulationMin { get; set; }
		public int iceAccumulationSum { get; set; }
		public DateTime moonriseTime { get; set; }
		public DateTime? moonsetTime { get; set; }
		public double precipitationProbabilityAvg { get; set; }
		public int precipitationProbabilityMax { get; set; }
		public int precipitationProbabilityMin { get; set; }
		public double pressureSurfaceLevelAvg { get; set; }
		public double pressureSurfaceLevelMax { get; set; }
		public double pressureSurfaceLevelMin { get; set; }
		public double rainAccumulationAvg { get; set; }
		public double rainAccumulationLweAvg { get; set; }
		public double rainAccumulationLweMax { get; set; }
		public int rainAccumulationLweMin { get; set; }
		public double rainAccumulationMax { get; set; }
		public int rainAccumulationMin { get; set; }
		public double rainAccumulationSum { get; set; }
		public double rainIntensityAvg { get; set; }
		public double rainIntensityMax { get; set; }
		public int rainIntensityMin { get; set; }
		public int sleetAccumulationAvg { get; set; }
		public int sleetAccumulationLweAvg { get; set; }
		public int sleetAccumulationLweMax { get; set; }
		public int sleetAccumulationLweMin { get; set; }
		public int sleetAccumulationLweSum { get; set; }
		public int sleetAccumulationMax { get; set; }
		public int sleetAccumulationMin { get; set; }
		public int sleetIntensityAvg { get; set; }
		public int sleetIntensityMax { get; set; }
		public int sleetIntensityMin { get; set; }
		public int snowAccumulationAvg { get; set; }
		public int snowAccumulationLweAvg { get; set; }
		public int snowAccumulationLweMax { get; set; }
		public int snowAccumulationLweMin { get; set; }
		public int snowAccumulationLweSum { get; set; }
		public int snowAccumulationMax { get; set; }
		public int snowAccumulationMin { get; set; }
		public int snowAccumulationSum { get; set; }
		public int snowIntensityAvg { get; set; }
		public int snowIntensityMax { get; set; }
		public int snowIntensityMin { get; set; }
		public DateTime sunriseTime { get; set; }
		public DateTime sunsetTime { get; set; }
		public double temperatureApparentAvg { get; set; }
		public double temperatureApparentMax { get; set; }
		public double temperatureApparentMin { get; set; }
		public double temperatureAvg { get; set; }
		public double temperatureMax { get; set; }
		public double temperatureMin { get; set; }
		public int uvHealthConcernAvg { get; set; }
		public int uvHealthConcernMax { get; set; }
		public int uvHealthConcernMin { get; set; }
		public int uvIndexAvg { get; set; }
		public int uvIndexMax { get; set; }
		public int uvIndexMin { get; set; }
		public double visibilityAvg { get; set; }
		public double visibilityMax { get; set; }
		public double visibilityMin { get; set; }
		public int weatherCodeMax { get; set; }
		public int weatherCodeMin { get; set; }
		public double windDirectionAvg { get; set; }
		public double windGustAvg { get; set; }
		public double windGustMax { get; set; }
		public double windGustMin { get; set; }
		public double windSpeedAvg { get; set; }
		public double windSpeedMax { get; set; }
		public double windSpeedMin { get; set; }
	}
}*/