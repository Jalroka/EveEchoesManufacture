using System;
using System.Collections.Generic;
using System.Text;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Data;

namespace EveEchoesManufacture.Converters
{
    public class ZeroToHiddenConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, string language)
        {
            string v = value as string;

            if (string.IsNullOrEmpty(v))
                return Visibility.Collapsed;
            else if(v.Equals("0"))
                return Visibility.Collapsed;
            else 
                return Visibility.Visible;
        }

        public object ConvertBack(object value, Type targetType, object parameter, string language)
        {
            return DependencyProperty.UnsetValue;
        }
    }
}
