using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;

namespace LeeDenbighsInteractiveCV.Services
{
    public class WidthConverter : IValueConverter
    {
        private const double TotalWidth = 424;

        public object Convert(object value, Type targetType, object patameters, CultureInfo culture)
        {
            if (value is double level)
            {
                return (TotalWidth * level) / 100.0;
            }

            return 0;
        }

        public object ConvertBack(object value, Type targetType, object patameters, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
