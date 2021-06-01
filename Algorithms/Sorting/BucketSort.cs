using System.Collections.Generic;

namespace Algorithms.Sorting
{
    public static class BucketSort
    {
        public static IEnumerable<double> Sort(double[] input)
        {
            var result = new List<double>();
            var bucket = new List<List<double>>();
            var n = input.Length;

            for (var i = 0; i < n; i++)
            {
                bucket.Add(new List<double>());
            }

            for (var i = 0; i < n; i++)
            {
                bucket[(int) (n * input[i])].Add(input[i]);
            }
            
            bucket.ForEach(InsertionSort.Sort);
            bucket.ForEach(result.AddRange);

            return result;
        }
    }
}