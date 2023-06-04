using CommunityToolkit.Mvvm.ComponentModel;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using WeatherApiTester.Model;
using WeatherApiTester.ViewModel;

namespace WeatherApiTester.ViewModel
{
	class ConfigurationViewModel : BaseViewModel
	{
		private WeatherModel _weatherModel;

		void testingGetProperties()
		{

			PropertyInfo[] properties = typeof(WeatherModel).GetProperties();
			foreach (PropertyInfo property in properties)
			{
				Trace.WriteLine(property.Name);
			}


		}
		public void addNewProfile()
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
}






// List of all possible properties, up/down,delete
// default configuration, return default
// option to get location from gps or set it by its name
//	

#region someOldSave
/*
private List<string> _propertyDisplayOrder;
public List<string> PropertyDisplayOrder
{
	get => _propertyDisplayOrder;
	set
	{
		if (_propertyDisplayOrder != value)
		{
			_propertyDisplayOrder = value;
			SaveOrderToPreferences();
			OnPropertyChanged();
		}
	}
}

private void SaveOrderToPreferences()
{
	var jsonString = JsonSerializer.Serialize(_propertyDisplayOrder);
	Preferences.Set("PropertyDisplayOrder", jsonString);
}
public ConfigurationViewModel()
{
	LoadOrderFromPreferences();
}

private void LoadOrderFromPreferences()
{
	var jsonString = Preferences.Get("PropertyDisplayOrder", string.Empty);
	if (!string.IsNullOrEmpty(jsonString))
	{
		_propertyDisplayOrder = JsonSerializer.Deserialize<List<string>>(jsonString);
	}
	else
	{
		_propertyDisplayOrder = new List<string>(); // Or default order
	}
}
*/
#endregion