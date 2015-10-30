using System.Collections.Generic;
using DBFilesClient.NET;

namespace SpellWork
{
    public static class CollectionExtensions
    {
        public static V GetValueOrDefault<V>(this DBCStorage<V> dictionary, uint key) where V : class, new()
        {
            if (dictionary == null)
                return new V();

            if (dictionary.ContainsKey(key))
                return dictionary[key];

            return new V();
        }

        public static IEnumerable<TSource> NewIfEmpty<TSource>(this IEnumerable<TSource> source) where TSource : class, new()
        {
            foreach (var element in source)
                yield return element ?? new TSource();

        }
    }
}
