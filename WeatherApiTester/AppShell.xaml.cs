using System.Collections.ObjectModel;

namespace WeatherApiTester;

public partial class AppShell : Shell
{
	public ObservableCollection<dynamic> FlyoutItems { get; set; }

	public AppShell()
	{
		FlyoutItems = new ObservableCollection<dynamic>()
			{
				new {  MenuTitle="MenuTitle1" },
				new {  MenuTitle="MenuTitle2" },
				new {  MenuTitle="MenuTitle3" },
				new {  MenuTitle="MenuTitle4" }
			};
		InitializeComponent();
		BindingContext = this;
	}
}
