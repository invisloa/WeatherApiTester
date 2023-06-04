using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeatherApiTester.Model.WeatherApiModels.TommorowIO
{
    public class WeatherModelTommorowIOCurrent : WeatherModelTommorowIOBase

	{
        public Data data { get; set; }
        public Location location { get; set; }
        public class Data
        {
            public DateTime time { get; set; }
            public Values values { get; set; }
        }
    }
}