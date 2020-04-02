using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Data;
using System.Globalization;
using System.Windows;

namespace UniversityRegistry.Data
{
    /// <summary>
    /// Class for converting enum values to boolean for data binding usage.
    /// </summary>
    public class EnumToBooleanConverter : IValueConverter
    {
        /// <summary>
        /// Converts an enum value into a boolean by comparing it to the object parameter.
        /// </summary>
        /// <param name="value">The enum value to convert</param>
        /// <param name="targetType">The type to convert to(should be boolean)</param>
        /// <param name="param">The enum value to compar eto</param>
        /// <param name="culture">The culture info.</param>
        /// <returns>True if the enum natches the param, false otherwise</returns>
        public object Convert(object value, Type targetType, object param, CultureInfo culture)
        {
            return value.Equals(param);
        }

        /// <summary>
        /// Converts a boolean into an enum value. If boolean is true parameter is returned.
        /// Otherwise DependencyProperty.UnsetValue is returned
        /// </summary>
        /// <param name="value">THe enum value to convert</param>
        /// <param name="targetType">The type to convert to(should be boolean)</param>
        /// <param name="param">The enum value to compar eto</param>
        /// <param name="culture">The culture info.</param>
        /// <returns>True if the enum natches the param, false otherwise</returns>
        public object ConvertBack(object value, Type targetType, object param, CultureInfo culture)
        {
            if ((bool)value) return param;
            return DependencyProperty.UnsetValue;
        }
    }
}
