using Algorithms.Sorting;
using FluentAssertions;
using NUnit.Framework;

namespace TestAlgorithms.Sorting
{
    public class QuickSortTests
    {
        [Test]
        public void Sort_SomeCollection_SortedCollection()
        {
            var input = new[] {2, 8, 7, 1, 3, 5, 6, 4};

            QuickSort.Sort(input);

            input.Should().Equal(1, 2, 3, 4, 5, 6, 7, 8);
        }
    }
}