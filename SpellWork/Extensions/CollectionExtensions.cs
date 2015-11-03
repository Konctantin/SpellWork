using System.Collections.Generic;
using DBFilesClient.NET;

namespace SpellWork
{
    public static class CollectionExtensions
    {
        public static V GetValueOrDefault<V>(this DBCStorage<V> dictionary, uint key) where V : class, new()
        {
            V val = default(V);
            dictionary?.TryGetValue(key, out val);
            return val;
        }

        public static IEnumerable<TSource> NewIfEmpty<TSource>(this IEnumerable<TSource> source) where TSource : class, new()
        {
            foreach (var element in source)
                yield return element ?? new TSource();

        }
    }
}
