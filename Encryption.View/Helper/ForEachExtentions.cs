using System;
using System.Collections.Generic;

namespace Encryption.View.Helper
{
    static class ForEachExtentions
    {
        public delegate void IndexedAction<T>(int index, T item);

        public static void ForEach<T>(this IEnumerable<T> source, IndexedAction<T> action)
        {
            int counter = 0;
            foreach (T item in source)
            {
                action.Invoke(counter++, item);
            }
        }

        public static void ForEach<T>(this IEnumerable<T> source, Action<T> action)
        {
            foreach (T item in source)
            {
                action.Invoke(item);
            }
        }
    }
}
