using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;

namespace WpfUI.ViewModel.ValueConverters
{
    public class BoolToRainConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            bool IsRaining = (bool)value;
            if (IsRaining)
            {
                return "Currently raining";
            }
            return "Currently not raining";
        }

        // For our app the user shouldn't decide if its raining or not
        // but we implementing the following method just for practicing
        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            string IsRaining = (string)value;

            if (IsRaining == "Currently raining")
            {
                return true;
            }
            return false;
        }
    }
}
