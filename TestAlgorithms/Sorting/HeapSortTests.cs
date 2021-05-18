using Algorithms.Sorting;
using FluentAssertions;
using NUnit.Framework;

namespace TestAlgorithms.Sorting
{
    public class HeapSortTests
    {
        [Test]
        public void Sort_SomeCollection_SortedCollection()
        {
            var input = new[] { 16, 14, 10, 8, 7, 9, 3, 2, 4, 1 };

            HeapSort.Sort(input);

            input.Should().Equal(1, 2, 3, 4, 7, 8, 9, 10, 14, 16);
        }
    }
}