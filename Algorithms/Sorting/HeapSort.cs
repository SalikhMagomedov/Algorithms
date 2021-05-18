using System;
using System.Collections.Generic;

namespace Algorithms.Sorting
{
    public static class HeapSort
    {
        public static void Sort<T>(IList<T> input) where T : IComparable
        {
            BuildMaxHeap(input);
            
            for (var i = input.Count - 1; i >= 1; i--)
            {
                (input[0], input[i]) = (input[i], input[0]);
                MaxHeapify(input, 0, i);
            }
        }
        
        private static void BuildMaxHeap<T>(IList<T> input) where T : IComparable
        {
            for (var i = input.Count / 2 - 1; i >= 0; i--)
            {
                MaxHeapify(input, i, input.Count);
            }
        }

        private static void MaxHeapify<T>(IList<T> input, int index, int heapSize) where T : IComparable
        {
            while (true)
            {
                var left = Left(index);
                var right = Right(index);
                var largest = index;

                if (left < heapSize && input[left].CompareTo(input[index]) == 1)
                {
                    largest = left;
                }

                if (right < heapSize && input[right].CompareTo(input[largest]) == 1)
                {
                    largest = right;
                }

                if (largest == index) return;

                (input[index], input[largest]) = (input[largest], input[index]);
                index = largest;
            }
        }

        private static int Left(int index)
        {
            index++;
            return (index << 1) - 1;
        }

        private static int Right(int index)
        {
            index++;
            return index << 1;
        }
    }
}