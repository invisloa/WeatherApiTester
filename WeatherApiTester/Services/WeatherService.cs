using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using WeatherApiTester.Model;

namespace WeatherApiTester.Services
{
	public class WeatherService
	{
		private static readonly HttpClient client = new HttpClient();

		public async Task<WeatherModel> GetWeatherDataAsync()
		{
			client.DefaultRequestHeaders.Accept.Clear();

			var stringTask = client.GetStringAsync("https://weather.visualcrossing.com/VisualCrossingWebServices/rest/services/timeline/Rzeczni%C3%B3w/2023-06-02/2023-06-03?unitGroup=metric&include=current%2Cdays%2Chours%2Calerts%2Cevents&key=8RJ424NSS5MUNADQ775YEY2ZS&contentType=json");

			var msg = await stringTask;
			var weatherData = JsonSerializer.Deserialize<WeatherModel>(msg);
			return weatherData;
		}
	}
}
