using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using WeatherApiTester.Model.WeatherApiModels;

namespace WeatherApiTester.Services.WeatherServices
{
    public class WeatherServiceVisualCrossing : IGetWeatherData
    {
        private static readonly HttpClient client = new HttpClient();
		public async Task<IWeatherCurrentModel> GetWeatherForecastHourlyAsync()
        {
            client.DefaultRequestHeaders.Accept.Clear();

            var stringTask = client.GetStringAsync("https://weather.visualcrossing.com/VisualCrossingWebServices/rest/services/timeline/Rzeczni%C3%B3w/last30days?unitGroup=metric&key=8RJ424NSS5MUNADQ775YEY2ZS&contentType=json");

            var options = new JsonSerializerOptions
            {
                PropertyNameCaseInsensitive = true // ignore case when mapping properties
            };
            var msg = await stringTask;
            int x = 2;

            IWeatherCurrentModel myDeserializedClass = JsonConvert.DeserializeObject<IWeatherCurrentModel>(msg);

            return myDeserializedClass;
        }

		public Task<IWeatherCurrentModel> GetWeatherHistoricAsync()
		{
			throw new NotImplementedException();
		}

		public Task<IWeatherCurrentModel> GetWeatherHourlyAsync()
		{
			throw new NotImplementedException();
		}
		public Task<IWeatherCurrentModel> GetWeatherCurrentAsync()
		{
			throw new NotImplementedException();
		}

		public Task<IWeatherCurrentModel> GetWeatherForecastDailyAsync()
		{
			throw new NotImplementedException();
		}
	}
}
