using System;
using System.Collections.Generic;

namespace Algorithms.Foundations
{
    public static class InsertionSort
    {
        public static void Sort<T>(IList<T> input) where T : IComparable
        {
            for (var i = 1; i < input.Count; i++)
            {
                var key = input[i];
                var j = i - 1;

                while (j >= 0 && input[j].CompareTo(key) == 1)
                {
                    input[j + 1] = input[j];
                    j--;
                }

                input[j + 1] = key;
            }
        }
    }
}