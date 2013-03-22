using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SpellWork.Converters
{
    public class EnumToUintConverter : ConverterBase<EnumToUintConverter>
    {
        public override object Convert(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            return (uint)(value ?? 0u);
        }
    }
}
