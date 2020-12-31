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
    public class InnerConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value is InnerBoltOptionEnum format1)
            {
                return GetString(format1);
            }

            return null;
        }



        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value is string s)
            {
                //return Enum.Parse(typeof(BracketOptionEnum), s.Substring(0, s.IndexOf(':')));
                return Enum.Parse(typeof(InnerBoltOptionEnum), s.Substring(0, s.IndexOf(':')));
                //return Enum.Parse(targetType, s.ToString(), true);
            }
            return null;
        }

        public string[] Strings => GetStrings();

        public static string GetString(InnerBoltOptionEnum format1)
        {
            //return format.ToString() + ": " + GetDescription(format);
            return format1.ToString() + ": " + GetDescription(format1);
        }

        public static string GetDescription(InnerBoltOptionEnum format1)
        {
            return format1.GetType().GetMember(format1.ToString())[0].GetCustomAttribute<DescriptionAttribute>().Description;

        }
        public static string[] GetStrings()
        {
            List<string> list = new List<string>();
            foreach (InnerBoltOptionEnum format1 in Enum.GetValues(typeof(InnerBoltOptionEnum)))
            {
                list.Add(GetString(format1));
            }

            return list.ToArray();
        }

    }
}
