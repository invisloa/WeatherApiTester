namespace WeatherApiTester.Views;

public partial class WeatherCurrent : ContentPage
{
	public WeatherCurrent()
	{
		
		InitializeComponent();
		BindingContext = new WeatherApiTester.ViewModel.WeatherCurrentTIO_VM();

	}
}