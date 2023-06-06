using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace WeatherApiTester.Services.Converters
{
    public static class WeatherModelToDictionary
	{
		public static Dictionary<string, string> ObjectToDictionary(object obj, string path)
		{
			Dictionary<string, string> dict = new Dictionary<string, string>();

			if (obj is IEnumerable<object> list)  // handle lists
			{
				int i = 0;
				foreach (var item in list)
				{
					var itemDict = ObjectToDictionary(item, path + $"[{i}]");
					foreach (var pair in itemDict)
					{
						dict.Add(pair.Key, pair.Value);
					}
					i++;
				}
			}
			else  // handle objects
			{
				foreach (PropertyInfo prop in obj.GetType().GetProperties())
				{
					object value = prop.GetValue(obj, null);
					string newPath = path == "" ? prop.Name : path + "." + prop.Name;
					if (value == null || IsSimpleType(value.GetType()))  // simple types can be added directly
					{
						dict.Add(newPath, value?.ToString());
					}
					else  // complex types need to be handled recursively
					{
						var subDict = ObjectToDictionary(value, newPath);
						foreach (var pair in subDict)
						{
							dict.Add(pair.Key, pair.Value);
						}
					}
				}
			}

			return dict;
		}
		public static bool IsSimpleType(Type type)
		{
			return
				type.IsPrimitive ||
				new Type[] {
				typeof(string),
				typeof(decimal),
				typeof(DateTime),
				typeof(DateTimeOffset),
				typeof(TimeSpan),
				typeof(Guid)
				}.Contains(type) ||
				Convert.GetTypeCode(type) != TypeCode.Object;
		}
	}

}
