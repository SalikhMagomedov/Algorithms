using System;
using System.Collections.Generic;

namespace Algorithms.Sorting
{
    public static class BubbleSort
    {
        public static void Sort<T>(IList<T> input) where T : IComparable
        {
            for (var i = 0; i < input.Count - 1; i++)
            {
                for (var j = input.Count - 1; j > i; j--)
                {
                    if (input[j].CompareTo(input[j - 1]) != -1) continue;

                    (input[j], input[j - 1]) = (input[j - 1], input[j]);
                }
            }
        }
    }
}