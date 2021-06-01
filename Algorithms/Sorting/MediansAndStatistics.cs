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

        public static T RandomizedSelect<T>(this IList<T> input, int index, Random rand) where T : IComparable
        {
            return input.RandomizedSelect(0, input.Count - 1, index, rand);
        }

        private static T RandomizedSelect<T>(this IList<T> input, int left, int right, int index, Random rand)
            where T : IComparable
        {
            while (true)
            {
                if (left == right) return input[left];

                var partition = input.RandomizedPartition(left, right, rand);
                var k = partition - left + 1;

                if (index == k) return input[partition];

                if (index < k)
                {
                    right = partition - 1;
                    continue;
                }

                left = partition + 1;
                index -= k;
            }
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