using System;
using System.Collections.Generic;

namespace SpellWork
{
    public class EnumExtension
    {
        public static IEnumerable<KeyValuePair<object, object>>GetValues(Type type, object noValue)
        {
            if (!type.IsEnum)
                throw new ArgumentException("type");

            yield return new KeyValuePair<object, object>(-1, noValue);

            foreach (var element in Enum.GetValues(type))
                yield return
                    new KeyValuePair<object, object>(element, element);
        }
    }
}
