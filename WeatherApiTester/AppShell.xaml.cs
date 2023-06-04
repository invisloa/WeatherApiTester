using System.Collections.ObjectModel;

namespace WeatherApiTester;

public partial class AppShell : Shell
{
	public FlyoutItem WeatherFlyoutPublic => WeatherFlyout;

	public AppShell()
	{
		InitializeComponent();
	}
}
