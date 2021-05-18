using System;
using System.Collections.Generic;

namespace Algorithms.Sorting
{
    public static class MergeSort
    {
        public static void Sort<T>(IList<T> input) where T : IComparable
        {
            Sort(input, 0, input.Count - 1);
        }
        
        private static void Sort<T>(IList<T> input, int left, int right) where T : IComparable
        {
            if (left >= right) return;
            
            var middle = (left + right) / 2;
            
            Sort(input, left, middle);
            Sort(input, middle + 1, right);
            Merge(input, left, middle, right);
        }

        private static void Merge<T>(IList<T> input, int left, int middle, int right) where T : IComparable
        {
            var leftCollection = new T[middle - left + 1];
            var rightCollection = new T[right - middle];

            for (var i = 0; i < leftCollection.Length; i++)
            {
                leftCollection[i] = input[left + i];
            }
            for (var i = 0; i < rightCollection.Length; i++)
            {
                rightCollection[i] = input[middle + i + 1];
            }

            for (int k = left, i = 0, j = 0; k <= right; k++)
            {
                if (i == leftCollection.Length)
                {
                    input[k] = rightCollection[j++];
                }
                else if (j == rightCollection.Length)
                {
                    input[k] = leftCollection[i++];
                }
                else if (leftCollection[i].CompareTo(rightCollection[j]) != 1)
                {
                    input[k] = leftCollection[i++];
                }
                else
                {
                    input[k] = rightCollection[j++];
                }
            }
        }
    }
}