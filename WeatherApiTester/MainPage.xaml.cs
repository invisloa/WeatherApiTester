using WeatherApiTester.Services;

namespace WeatherApiTester;

public partial class MainPage : ContentPage
{
	int count = 0;

	public MainPage()
	{
		InitializeComponent();
	}
	private void OnCounterClicked(object sender, EventArgs e)
	{
		var content = new ShellContent
		{
			Title = "test",
			Content = new MainPage(),
			Route = "221",
		};

		// Get the current Shell (should be your AppShell instance)
		var currentShell = (AppShell)Shell.Current;

		// Add the new content to the WeatherFlyout in AppShell
		currentShell.WeatherFlyoutPublic.Items.Add(content);
		Shell.Current.GoToAsync("//221");
	}
}

