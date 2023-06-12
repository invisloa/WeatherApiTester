using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeatherApiTester.Model.WeatherApiModels
{
    public class WeatherProperty
    {
        public string Name { get; set; }
        public string Value { get; set; }
        public bool IsVisible { get; set; }
        public string IconPath { get; set; }
		public WeatherProperty(string name, string value, bool isVisible, string iconPath) 
        {
            Name = name;
            Value = value;  
            IsVisible = isVisible;
            IconPath = iconPath;
        }
    }
}
