using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;
using static Ngdbeambracketconnect.Model.BracketEnum;

namespace Ngdbeambracketconnect.Converter
{
    public class LengthConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value is LengthOptionEnum format)
            {
                return GetString(format);
            }

            return null;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value is string s)
            {
                //return Enum.Parse(typeof(BracketOptionEnum), s.Substring(0, s.IndexOf(':')));
                return s;
            }
            return null;
        }

        public string[] Strings => GetStrings();

        public static string GetString(LengthOptionEnum format)
        {
            //return format.ToString() + ": " + GetDescription(format);
            return GetDescription(format);
        }

        public static string GetDescription(LengthOptionEnum format)
        {
            return format.GetType().GetMember(format.ToString())[0].GetCustomAttribute<DescriptionAttribute>().Description;

        }
        public static string[] GetStrings()
        {
            List<string> list = new List<string>();
            foreach (LengthOptionEnum format in Enum.GetValues(typeof(LengthOptionEnum)))
            {
                list.Add(GetString(format));
            }

            return list.ToArray();
        }
    }
}
