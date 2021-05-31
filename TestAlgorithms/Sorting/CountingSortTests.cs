using Algorithms.Sorting;
using FluentAssertions;
using NUnit.Framework;

namespace TestAlgorithms.Sorting
{
    public class CountingSortTests
    {
        [Test]
        public void Sort_SomeIntArray_SortedIntArray()
        {
            var input = new[] {2, 5, 3, 0, 2, 3, 0, 3};

            var result = CountingSort.Sort(input, 5);

            result.Should().Equal(0, 0, 2, 2, 3, 3, 3, 5);
        }
    }
}