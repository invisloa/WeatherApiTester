using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeatherApiTester.Model
{
	public class WeatherModel
	{
		public int queryCost { get; set; }
		public double latitude { get; set; }
		public double longitude { get; set; }
		public string resolvedAddress { get; set; } //"resolvedAddress":"Rzeczniów, Woj. Mazowieckie, Polska",
		public string address { get; set; }         //"address":"Rzeczniów"
		public string timezone { get; set; }
		public double tzoffset { get; set; }
		public string description { get; set; }     //"description":"Similar temperatures continuing with no rain expected."
		public List<Day> days { get; set; }
		public List<object> alerts { get; set; }
		public CurrentConditions currentConditions { get; set; }
	}
	public class CurrentConditions
	{
		public string datetime { get; set; }
		public int datetimeEpoch { get; set; }
		public double temp { get; set; }
		public double feelslike { get; set; }
		public double humidity { get; set; }
		public double dew { get; set; }
		public int precip { get; set; }
		public int precipprob { get; set; }
		public int snow { get; set; }
		public int snowdepth { get; set; }
		public object preciptype { get; set; }
		public object windgust { get; set; }
		public double windspeed { get; set; }
		public int winddir { get; set; }
		public double pressure { get; set; }
		public int visibility { get; set; }
		public double cloudcover { get; set; }
		public int solarradiation { get; set; }
		public double solarenergy { get; set; }
		public int uvindex { get; set; }
		public string conditions { get; set; }
		public string icon { get; set; }
		public List<string> stations { get; set; }
		public string source { get; set; }
		public string sunrise { get; set; }
		public int sunriseEpoch { get; set; }
		public string sunset { get; set; }
		public int sunsetEpoch { get; set; }
		public double moonphase { get; set; }
	}
	public class Day
	{
		public string datetime { get; set; }
		public int datetimeEpoch { get; set; }
		public double tempmax { get; set; }
		public int tempmin { get; set; }
		public double temp { get; set; }
		public double feelslikemax { get; set; }
		public double feelslikemin { get; set; }
		public double feelslike { get; set; }
		public double dew { get; set; }
		public double humidity { get; set; }
		public int precip { get; set; }
		public int precipprob { get; set; }
		public int precipcover { get; set; }
		public List<string> preciptype { get; set; }
		public int snow { get; set; }
		public int snowdepth { get; set; }
		public int windgust { get; set; }
		public double windspeed { get; set; }
		public double winddir { get; set; }
		public double pressure { get; set; }
		public double cloudcover { get; set; }
		public double visibility { get; set; }
		public double solarradiation { get; set; }
		public double solarenergy { get; set; }
		public int uvindex { get; set; }
		public int severerisk { get; set; }
		public string sunrise { get; set; }
		public int sunriseEpoch { get; set; }
		public string sunset { get; set; }
		public int sunsetEpoch { get; set; }
		public double moonphase { get; set; }
		public string conditions { get; set; }
		public string description { get; set; }
		public string icon { get; set; }
		public List<string> stations { get; set; }
		public string source { get; set; }
		public List<Hour> hours { get; set; }
	}
	public class Hour
	{
		public string datetime { get; set; }
		public int datetimeEpoch { get; set; }
		public double temp { get; set; }
		public double feelslike { get; set; }
		public double humidity { get; set; }
		public double dew { get; set; }
		public int precip { get; set; }
		public int precipprob { get; set; }
		public int snow { get; set; }
		public int snowdepth { get; set; }
		public List<string> preciptype { get; set; }
		public double windgust { get; set; }
		public double windspeed { get; set; }
		public double winddir { get; set; }
		public int pressure { get; set; }
		public double visibility { get; set; }
		public double cloudcover { get; set; }
		public int solarradiation { get; set; }
		public double solarenergy { get; set; }
		public int uvindex { get; set; }
		public int severerisk { get; set; }
		public string conditions { get; set; }
		public string icon { get; set; }
		public object stations { get; set; }
		public string source { get; set; }
	}

}
