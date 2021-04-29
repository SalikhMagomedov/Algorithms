using System;
using System.Collections.Generic;

namespace Algorithms.Foundations
{
    public static class InsertionSort
    {
        public static void Sort<T>(IList<T> collection) where T : IComparable
        {
            for (var i = 1; i < collection.Count; i++)
            {
                var key = collection[i];
                var j = i - 1;

                while (j >= 0 && collection[j].CompareTo(key) == 1)
                {
                    collection[j + 1] = collection[j];
                    j--;
                }

                collection[j + 1] = key;
            }
        }
    }
}