using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using WeatherApiTester.Model.WeatherApiModels;
using WeatherApiTester.Model.WeatherApiModels.TommorowIO;

namespace WeatherApiTester.Services.WeatherServices
{
	public class WeatherServiceTommorowIO : IGetWeatherData
	{
		private static readonly HttpClient client = new HttpClient();
		private const string _myApiKey = "Cj66O8OLTih8hPqA7AOKfevJuX11N1hp";
		private const string _location = "Warszawa";

		static WeatherServiceTommorowIO()
		{
			client.DefaultRequestHeaders.Accept.Clear();
			client.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));
		}

		private Uri CreateUri(string endpoint, string parameters = "")
		{
			return new Uri($"https://api.tomorrow.io/v4/weather/{endpoint}?location={_location}&apikey={_myApiKey}{parameters}");
		}

		private async Task<IWeatherModel> SendRequestAsync<T>(Uri uri)
		{
			HttpResponseMessage response = await client.GetAsync(uri);

			if (!response.IsSuccessStatusCode)
			{
				throw new Exception($"Error: {response.StatusCode}");
			}

			string responseBody = await response.Content.ReadAsStringAsync();
			return JsonConvert.DeserializeObject<WeatherModelTommorowIODailyForecast>(responseBody);
		}

		public Task<IWeatherModel> GetWeatherCurrentAsync()
		{
			return SendRequestAsync<WeatherModelTommorowIOCurrent>(CreateUri("realtime"));
		}

		public Task<IWeatherModel> GetWeatherForecastDailyAsync()
		{
			return SendRequestAsync<WeatherModelTommorowIODailyForecast>(CreateUri("forecast", "&timesteps=1d"));
		}

		public Task<IWeatherModel> GetWeatherForecastHourlyAsync()
		{
			return SendRequestAsync<WeatherModelTommorowIOHourlyForecast>(CreateUri("forecast", "&timesteps=1h"));
		}

		public Task<IWeatherModel> GetWeatherHistoricAsync()
		{
			throw new NotImplementedException();
		}
	}
}
