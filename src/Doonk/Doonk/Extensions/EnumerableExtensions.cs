using System;
using System.Collections.Generic;
using System.Linq;

namespace Doonk.Extensions
{
    public static class EnumerableExtensions
    {
        public static bool IsNullOrEmpty<T>(this ICollection<T> source)
            => source == null || source.IsEmpty();

        public static bool IsEmpty<T>(this ICollection<T> source)
            => source.Count == 0;

        public static bool IsNullOrEmpty<T>(this IEnumerable<T> source)
            => source == null || source.IsEmpty();

        public static bool IsEmpty<T>(this IEnumerable<T> source)
            => !source.Any();
        
        public static void ForEach<T>(this IEnumerable<T> source, Action<T> action)
        {
            foreach (var item in source)
                action(item);
        }
        
        public static void ForEach<K, V>(this IDictionary<K, V> source, Action<K, V> action)
        {
            foreach (var (k, v) in source)
                action(k, v);
        }
        
        public static void AddRange<K, V>(this IDictionary<K, V> source, IDictionary<K, V> other)
        {
            foreach (var (k, v) in other)
                source.Add(k, v);
        }

        public static void AddRange<K, V>(this IDictionary<K, V> source, IEnumerable<KeyValuePair<K, V>> other)
        {
            foreach (var o in other)
                source.Add(o);
        }

        public static void AddRange<T>(this ICollection<T> source, IEnumerable<T> other)
        {
            foreach (var o in other)
                source.Add(o);
        }

        public static void Add<T>(this IList<T> source, IEnumerable<T> other)
            => source.AddRange(other);
    }
}