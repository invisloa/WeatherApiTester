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
	public class WeatherServiceTommorowIO : IGetWeatherDataSvc
	{
		private static readonly HttpClient client = new HttpClient();
		private const string _myApiKey = "Cj66O8OLTih8hPqA7AOKfevJuX11N1hp";
		private const string _location = "Warszawa";
		IWeatherCurrentModel weatherCurrentModel = Factory.CreateWeatherCurrentDataModel;

		static WeatherServiceTommorowIO()
		{
			client.DefaultRequestHeaders.Accept.Clear();
			client.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));
		}

		private Uri CreateUri(string endpoint, string parameters = "")
		{
			return new Uri($"https://api.tomorrow.io/v4/weather/{endpoint}?location={_location}&apikey={_myApiKey}{parameters}");
		}

		private async Task<IWeatherCurrentModel> SendRequestAsync<T>(Uri uri)
		{
			HttpResponseMessage response;
			System.Net.ServicePointManager.SecurityProtocol = System.Net.SecurityProtocolType.Tls12;

			try
			{
				response = await client.GetAsync(uri);
			}
			catch (Exception ex)
			{
				Console.WriteLine($"An error occurred: {ex.Message}");
				throw;
			}

			if (!response.IsSuccessStatusCode)
			{
				throw new Exception($"Error: {response.StatusCode}");
			}

			string responseBody = await response.Content.ReadAsStringAsync();
			try
			{
				weatherCurrentModel = JsonConvert.DeserializeObject<IWeatherCurrentModel>(responseBody);
				return weatherCurrentModel;
			}
			catch (Exception ex) { await Console.Out.WriteLineAsync($"{ex}"); }
			return null;
		}

		public Task<IWeatherCurrentModel> GetWeatherCurrentAsync()
		{
			return SendRequestAsync<IWeatherCurrentModel>(CreateUri("realtime"));
		}
	}
}
