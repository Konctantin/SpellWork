using System;

namespace SpellWork.Converters
{
    public class BooleanToImageConverter : ConverterBase<BooleanToImageConverter>
    {
        public override object Convert(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            return (bool)value 
                    ? new Uri("pack://application:,,,/SpellWork;component/Resources/plus.ico") 
                    : new Uri("pack://application:,,,/SpellWork;component/Resources/minus.ico");
        }
    }
}
