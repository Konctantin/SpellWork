using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Media;

namespace SpellWork.Converters
{
    public class BooleanToColorConverter : ConverterBase<BooleanToColorConverter>
    {
        public override object Convert(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            return (bool)value ? new SolidColorBrush(Colors.Green) : new SolidColorBrush(Colors.Red);
        }
    }
}
