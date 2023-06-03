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

			ShellContent content = new ShellContent();
			content.Title = "test";
			content.FlyoutIcon = "dotnet_bot.svg";
			content.Content = new MainPage();

			AppShell.Current.Items.Add(content);
	}
}

