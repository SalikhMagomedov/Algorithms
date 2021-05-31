using System.Collections.Generic;

namespace Algorithms.Sorting
{
    public static class CountingSort
    {
        public static IEnumerable<int> Sort(int[] input, int maxInt)
        {
            var result = new int[input.Length];
            var temp = new int[maxInt + 1];

            foreach (var e in input) temp[e]++;

            for (var i = 1; i < temp.Length; i++) temp[i] += temp[i - 1];

            for (var i = input.Length - 1; i >= 0; i--)
            {
                result[temp[input[i]] - 1] = input[i];
                temp[input[i]]--;
            }

            return result;
        }
    }
}