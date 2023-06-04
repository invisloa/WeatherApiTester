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
		string _myApiKey = "Cj66O8OLTih8hPqA7AOKfevJuX11N1hp";
		string _location = "Warszawa";

		public async Task<IWeatherModel> GetWeatherCurrentAsync()
		{
			client.DefaultRequestHeaders.Accept.Clear();
			client.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));

			try
			{
				var uri = new Uri($"https://api.tomorrow.io/v4/weather/realtime?location={_location}&apikey={_myApiKey}");

				HttpResponseMessage response = await client.GetAsync(uri);
				if (response.IsSuccessStatusCode)
				{
					string responseBody = await response.Content.ReadAsStringAsync();

					IWeatherModel myDeserializedClass = JsonConvert.DeserializeObject<WeatherModelTommorowIOCurrent>(responseBody);

					return myDeserializedClass;
				}
				else
				{
					throw new Exception($"Error: {response.StatusCode}");
				}
			}
			catch (Exception ex)
			{
				throw new Exception($"Exception: {ex.Message}");
			}
		}

		public async Task<IWeatherModel> GetWeatherForecastAsync()
		{
			throw new NotImplementedException();
		}

		public Task<IWeatherModel> GetWeatherHistoricAsync()
		{
			throw new NotImplementedException();
		}

		public Task<IWeatherModel> GetWeatherHourlyAsync()
		{
			throw new NotImplementedException();
		}
	}
}
