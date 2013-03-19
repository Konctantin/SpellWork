using System;
using System.Windows.Media;

namespace SpellWork.Converters
{
    public class BooleanToColorConverter : ConverterBase<BooleanToColorConverter>
    {
        public override object Convert(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            return (bool)value ? new SolidColorBrush(Color.FromArgb(0xFF, 0x17, 0xAD, 0x1A)) : new SolidColorBrush(Colors.Red);
        }
    }
}
