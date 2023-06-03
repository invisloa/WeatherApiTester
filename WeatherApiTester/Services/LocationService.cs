using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeatherApiTester.Services
{
	public class LocationService
	{
		public async Task<Location> GetCurrentLocationAsync()
		{
			try
			{
				var request = new GeolocationRequest(GeolocationAccuracy.Medium);
				var location = await Geolocation.GetLocationAsync(request);

				if (location != null)
				{
					return location;
				}
			}
			catch (FeatureNotSupportedException fnsEx)
			{
				await Shell.Current.DisplayAlert("Error", "FeatureNotSupportedException", "Ok");
			}
			catch (FeatureNotEnabledException fneEx)
			{
				await Shell.Current.DisplayAlert("Error", "FeatureNotEnabledException", "Ok");
			}
			catch (PermissionException pEx)
			{
				await Shell.Current.DisplayAlert("Error", "PermissionException", "Ok");
			}
			catch (Exception ex)
			{
				await Shell.Current.DisplayAlert("Error", "Exception", "Ok");
			}

			return null;
		}
	}
}
