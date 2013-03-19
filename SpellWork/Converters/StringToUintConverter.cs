using System;
using System.Globalization;

namespace SpellWork.Converters
{
    public class StringToUintConverter : ConverterBase<StringToUintConverter>
    {
        public override object Convert(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            uint res = 0u;

            if (string.IsNullOrWhiteSpace(value as string))
                return res;

            var strValue = value as string;

            if (strValue.StartsWith("0x"))
                uint.TryParse(strValue.Substring(2), NumberStyles.AllowHexSpecifier, CultureInfo.CurrentCulture, out res);
            else if (strValue.EndsWith("h"))
                uint.TryParse(strValue.Substring(0, strValue.Length - 2), NumberStyles.AllowHexSpecifier, CultureInfo.CurrentCulture, out res);
            else
                uint.TryParse(strValue, out res);

            return res;
        }
    }
}
