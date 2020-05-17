﻿using System;
using System.Globalization;
using Xamarin.Forms;

namespace CedesistemasApp.Converters
{
    public class CalificationToImageConverter: IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value == null)
                return value;

            var calification = (int)value;
            if (calification <= 2)
                return "bad";
            else if(calification==3)
                return "neutro";
            else
                return "good";
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
