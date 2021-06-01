using Algorithms.Sorting;
using FluentAssertions;
using NUnit.Framework;

namespace TestAlgorithms.Sorting
{
    public class BucketSortTests
    {
        [Test]
        public void Sort_SomeDoubleArrayFromZeroToOne_SortedDoubleArray()
        {
            var input = new[] {.78, .17, .39, .26, .72, .94, .21, .12, .23, .68};

            var result = BucketSort.Sort(input);

            result.Should().Equal(.12, .17, .21, .23, .26, .39, .68, .72, .78, .94);
        }
    }
}