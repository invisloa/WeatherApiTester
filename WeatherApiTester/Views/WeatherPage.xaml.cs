using WeatherApiTester.Services;
using WeatherApiTester.ViewModel;
using WeatherApiTester.Model.WeatherApiModels;
using WeatherApiTester.Helpers;
using static WeatherApiTester.ViewModel.WeatherCurrentTIO_VM;

namespace WeatherApiTester.Views;

public partial class WeatherPage : ContentPage
{
	public WeatherPage()
	{
		InitializeComponent();
		try 
		{
			BindingContext = ServiceHelper.GetService<WeatherCurrentTIO_VM>();
		}
		catch (Exception ex) 
		{
            Console.WriteLine(ex);
        }

	}
}