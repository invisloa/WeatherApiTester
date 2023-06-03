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
			PermissionStatus status = await Permissions.CheckStatusAsync<Permissions.LocationWhenInUse>();
			status = await CheckAndRequestLocationPermission();

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
		public async Task<PermissionStatus> CheckAndRequestLocationPermission()
		{
			PermissionStatus status = await Permissions.CheckStatusAsync<Permissions.LocationWhenInUse>();

			if (status == PermissionStatus.Granted)
				return status;

			if (status == PermissionStatus.Denied && DeviceInfo.Platform == DevicePlatform.iOS)
			{
				// Prompt the user to turn on in settings
				// On iOS once a permission has been denied it may not be requested again from the application
				return status;
			}

			if (Permissions.ShouldShowRationale<Permissions.LocationWhenInUse>())
			{
				// Prompt the user with additional information as to why the permission is needed
			}

			status = await Permissions.RequestAsync<Permissions.LocationWhenInUse>();

			return status;
		}

	}

}
