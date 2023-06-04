using CommunityToolkit.Mvvm.ComponentModel;
using System;
using System.Collections.Generic;
using System.Linq;
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