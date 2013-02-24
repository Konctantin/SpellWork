using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SpellWork
{
    public class EnumExtension
    {
        public static IEnumerable<object> GetValues(Type type, object firstValue)
        {
            if (!type.IsEnum)
                throw new ArgumentException("type");

            yield return firstValue;
            foreach (var element in Enum.GetValues(type))
                yield return element;
        }
    }
}
