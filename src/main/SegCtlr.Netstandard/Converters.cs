using System;
using System.Collections.Generic;
using System.Globalization;
using System.Runtime.CompilerServices;
using System.Text;
using Xamarin.Forms;

namespace Plugin.Segmented.Control
{
    public class WeatherUnitToNumberConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return (string)value == "Celsius" ? "0" : "1";
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return (int)value == 0 ? "Celsius" : "Farenheit";
        }
    }

    public class InverseBooleanConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return !(bool)value;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return !(bool)value;
        }
    }

    public class RefreshLabelConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            var values = value as IEnumerable<string>;
            var labels = new List<string>();
            foreach(var label in values)
            {
                var split = label.Split(" ".ToCharArray());
                var shortLabel = split[0] + split[1].Substring(0, 1).ToLower();
                labels.Add(shortLabel);
            }
            return labels;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }

    public class RefreshNumberConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            switch (value)
            {
                case "30 Seconds":
                    return "0";
                case "1 Minute":
                    return "1";
                case "2 Minutes":
                    return "2";
                case "5 Minutes":
                    return "3";
            }
            return null;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            switch (value)
            {
                case 0:
                    return "30 Seconds";
                case 1:
                    return "1 Minute";
                case 2:
                    return "2 Minutes";
                case 3:
                    return "5 Minutes";
            }
            return null;
        }
    }

    public class ImageSourceConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return (string)value == "Flickr" ? "0" : "1";
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return (int)value == 0 ? "Flickr" : "Cleveland Museum of Art";
        }
    }
}
