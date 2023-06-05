using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeatherApiTester.Model.WeatherApiModels.TommorowIO
{
	public class WeatherModelTommorowIODailyForecast : WeatherModelTommorowIOBase
	{
		public Timelines timelines { get; set; }
		public Location location { get; set; }

		public class Daily
		{
			public DateTime time { get; set; }
			public Values values { get; set; }
		}

		public class Timelines
		{
			public List<Daily> daily { get; set; }
		}
		public class Values
		{
			public double cloudBaseAvg { get; set; }
			public double cloudBaseMax { get; set; }
			public double cloudBaseMin { get; set; }
			public double cloudCeilingAvg { get; set; }
			public double cloudCeilingMax { get; set; }
			public double cloudCeilingMin { get; set; }
			public double cloudCoverAvg { get; set; }
			public double cloudCoverMax { get; set; }
			public double cloudCoverMin { get; set; }
			public double dewPointAvg { get; set; }
			public double dewPointMax { get; set; }
			public double dewPointMin { get; set; }
			public double evapotranspirationAvg { get; set; }
			public double evapotranspirationMax { get; set; }
			public double evapotranspirationMin { get; set; }
			public double evapotranspirationSum { get; set; }
			public double freezingRainIntensityAvg { get; set; }
			public double freezingRainIntensityMax { get; set; }
			public double freezingRainIntensityMin { get; set; }
			public double humidityAvg { get; set; }
			public double humidityMax { get; set; }
			public double humidityMin { get; set; }
			public double iceAccumulationAvg { get; set; }
			public double iceAccumulationLweAvg { get; set; }
			public double iceAccumulationLweMax { get; set; }
			public double iceAccumulationLweMin { get; set; }
			public double iceAccumulationLweSum { get; set; }
			public double iceAccumulationMax { get; set; }
			public double iceAccumulationMin { get; set; }
			public double iceAccumulationSum { get; set; }
			public DateTime moonriseTime { get; set; }
			public DateTime moonsetTime { get; set; }
			public double precipitationProbabilityAvg { get; set; }
			public double precipitationProbabilityMax { get; set; }
			public double precipitationProbabilityMin { get; set; }
			public double pressureSurfaceLevelAvg { get; set; }
			public double pressureSurfaceLevelMax { get; set; }
			public double pressureSurfaceLevelMin { get; set; }
			public double rainAccumulationAvg { get; set; }
			public double rainAccumulationLweAvg { get; set; }
			public double rainAccumulationLweMax { get; set; }
			public double rainAccumulationLweMin { get; set; }
			public double rainAccumulationMax { get; set; }
			public double rainAccumulationMin { get; set; }
			public double rainAccumulationSum { get; set; }
			public double rainIntensityAvg { get; set; }
			public double rainIntensityMax { get; set; }
			public double rainIntensityMin { get; set; }
			public double sleetAccumulationAvg { get; set; }
			public double sleetAccumulationLweAvg { get; set; }
			public double sleetAccumulationLweMax { get; set; }
			public double sleetAccumulationLweMin { get; set; }
			public double sleetAccumulationLweSum { get; set; }
			public double sleetAccumulationMax { get; set; }
			public double sleetAccumulationMin { get; set; }
			public double sleetIntensityAvg { get; set; }
			public double sleetIntensityMax { get; set; }
			public double sleetIntensityMin { get; set; }
			public double snowAccumulationAvg { get; set; }
			public double snowAccumulationLweAvg { get; set; }
			public double snowAccumulationLweMax { get; set; }
			public double snowAccumulationLweMin { get; set; }
			public double snowAccumulationLweSum { get; set; }
			public double snowAccumulationMax { get; set; }
			public double snowAccumulationMin { get; set; }
			public double snowAccumulationSum { get; set; }
			public double snowIntensityAvg { get; set; }
			public double snowIntensityMax { get; set; }
			public double snowIntensityMin { get; set; }
			public DateTime sunriseTime { get; set; }
			public DateTime sunsetTime { get; set; }
			public double temperatureApparentAvg { get; set; }
			public double temperatureApparentMax { get; set; }
			public double temperatureApparentMin { get; set; }
			public double temperatureAvg { get; set; }
			public double temperatureMax { get; set; }
			public double temperatureMin { get; set; }
			public double uvHealthConcernAvg { get; set; }
			public double uvHealthConcernMax { get; set; }
			public double uvHealthConcernMin { get; set; }
			public double uvIndexAvg { get; set; }
			public double uvIndexMax { get; set; }
			public double uvIndexMin { get; set; }
			public double visibilityAvg { get; set; }
			public double visibilityMax { get; set; }
			public double visibilityMin { get; set; }
			public double weatherCodeMax { get; set; }
			public double weatherCodeMin { get; set; }
			public double windDirectionAvg { get; set; }
			public double windGustAvg { get; set; }
			public double windGustMax { get; set; }
			public double windGustMin { get; set; }
			public double windSpeedAvg { get; set; }
			public double windSpeedMax { get; set; }
			public double windSpeedMin { get; set; }
		}

	}
}
