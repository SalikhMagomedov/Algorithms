using System.Collections.Generic;

namespace Algorithms.Foundations
{
    public static class FindMaximumSubarray
    {
        public static (int low, int high, int sum) Find(int[] input)
        {
            return Find(input, 0, input.Length - 1);
        }

        private static (int low, int hight, int sum) Find(IReadOnlyList<int> input, int low, int high)
        {
            if (low == high) return (low, high, input[low]);

            var middle = (low + high) / 2;
            var left = Find(input, low, middle);
            var right = Find(input, middle + 1, high);
            var cross = FindMaxCrossingSubarray(input, low, middle, high);

            if (left.sum >= right.sum && left.sum >= cross.sum) return left;
            if (right.sum >= left.sum && right.sum >= cross.sum) return right;

            return cross;
        }

        private static (int low, int hight, int sum) FindMaxCrossingSubarray(IReadOnlyList<int> input, int low, int middle, int high)
        {
            var sum = 0;
            var leftSum = int.MinValue;
            var maxLeft = low;

            for (var i = middle; i >= low; i--)
            {
                sum += input[i];
                
                if (sum <= leftSum) continue;
                
                leftSum = sum;
                maxLeft = i;
            }

            var rightSum = int.MinValue;
            var maxRight = high;

            sum = 0;
            for (var i = middle + 1; i <= high; i++)
            {
                sum += input[i];
                
                if (sum <= rightSum) continue;

                rightSum = sum;
                maxRight = i;
            }

            return (maxLeft, maxRight, leftSum + rightSum);
        }
    }
}