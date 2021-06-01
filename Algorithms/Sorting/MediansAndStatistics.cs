using System;
using System.Collections.Generic;

namespace Algorithms.Sorting
{
    public static class MediansAndStatistics
    {
        public static T Minimum<T>(this IList<T> input) where T : IComparable
        {
            return input.Extremum((min, i) => min.CompareTo(i) == 1);
        }

        public static T Maximum<T>(this IList<T> input) where T : IComparable
        {
            return input.Extremum((max, i) => max.CompareTo(i) == -1);
        }

        private static T Extremum<T>(this IList<T> input, Func<T, T, bool> comparison)
        {
            var result = input[0];

            for (var i = 1; i < input.Count; i++)
            {
                if (!comparison(result, input[i])) continue;

                result = input[i];
            }

            return result;
        }
    }
}