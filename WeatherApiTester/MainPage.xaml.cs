using WeatherApiTester.Services;

namespace WeatherApiTester;

public partial class MainPage : ContentPage
{
	int count = 0;

	public MainPage()
	{
		InitializeComponent();
	}

	private async void OnCounterClicked(object sender, EventArgs e)
	{
		/*		LocationService location = new LocationService();
				PermissionStatus status = await Permissions.CheckStatusAsync<Permissions.LocationWhenInUse>();
				status = await Permissions.RequestAsync<Permissions.LocationWhenInUse>();
				status = await CheckAndRequestLocationPermission();
				Location newLocation = await location.GetCurrentLocationAsync();
				count++;

				if (count == 1)
					CounterBtn.Text = $"Clicked {newLocation.ToString()} time";
				else
					CounterBtn.Text = $"Clicked time";

				SemanticScreenReader.Announce(CounterBtn.Text);*/
			ShellContent content = new ShellContent();
			content.Title = "test";
			content.FlyoutIcon = "dotnet_bot.svg";
			content.Content = new MainPage();

			AppShell.Current.Items.Add(content);
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

