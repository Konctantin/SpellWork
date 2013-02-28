using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DBFilesClient.NET;

namespace SpellWork
{
    public static class CollectionExtensions
    {
        public static V GetValueOrDefault<V>(this DBCStorage<V> dictionary, uint key) where V : class, new()
        {
            if (dictionary == null)
                return default(V);

            if (dictionary.ContainsKey(key))
                return dictionary[key];

            return default(V);
        }

        public static IEnumerable<TSource> NewIfEmpty<TSource>(this IEnumerable<TSource> source) where TSource : class, new()
        {
            foreach (var str in source)
                yield return str == null ? new TSource() : str;

        }
    }
}
