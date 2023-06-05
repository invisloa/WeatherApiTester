using WeatherApiTester.Services;
using WeatherApiTester.ViewModel;
using WeatherApiTester.Model.WeatherApiModels;
using WeatherApiTester.Helpers;

namespace WeatherApiTester.Views;

public partial class WeatherPage : ContentPage
{
	public WeatherPage()
	{
		InitializeComponent();
		try 
		{
			BindingContext = ServiceHelper.GetService<WeatherViewModel>();
		}
		catch (Exception ex) 
		{
            Console.WriteLine(ex);
        }

	}
}