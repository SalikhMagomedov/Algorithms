using System;
using System.Collections.Generic;

namespace Algorithms.Sorting
{
    public static class QuickSort
    {
        public static void Sort<T>(IList<T> input) where T : IComparable
        {
            Sort(input, 0, input.Count - 1);
        }

        private static void Sort<T>(IList<T> input, int left, int right) where T : IComparable
        {
            while (left < right)
            {
                var partition = Partition(input, left, right);

                Sort(input, left, partition - 1);
                left = partition + 1;
            }
        }

        private static int Partition<T>(IList<T> input, int left, int right) where T : IComparable
        {
            var x = input[right];
            var i = left - 1;

            for (var j = left; j < right; j++)
            {
                if (input[j].CompareTo(x) == 1) continue;
                
                i++;
                (input[i], input[j]) = (input[j], input[i]);
            }

            (input[i + 1], input[right]) = (input[right], input[i + 1]);

            return i + 1;
        }
    }
}