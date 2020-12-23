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
    public class EnumConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value is BracketOptionEnum format)
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
                return Enum.Parse(typeof(BracketOptionEnum), s.Substring(0));
            }
            return null;
        }

        public string[] Strings => GetStrings();

        public static string GetString(BracketOptionEnum format)
        {
            //return format.ToString() + ": " + GetDescription(format);
            return format.ToString();
        }

        public static string GetDescription(BracketOptionEnum format)
        {
            return format.GetType().GetMember(format.ToString())[0].GetCustomAttribute<DescriptionAttribute>().Description;

        }
        public static string[] GetStrings()
        {
            List<string> list = new List<string>();
            foreach (BracketOptionEnum format in Enum.GetValues(typeof(BracketOptionEnum)))
            {
                list.Add(GetString(format));
            }

            return list.ToArray();
        }

       
    }
}
