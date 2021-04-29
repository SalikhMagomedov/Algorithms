using Algorithms.Foundations;
using FluentAssertions;
using NUnit.Framework;

namespace TestAlgorithms.Foundations
{
    public class MergeSortTests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Sort_SomeCollection_SortedCollection()
        {
            var input = new[] {5, 2, 4, 7, 1, 3, 2, 6};
            
            MergeSort.Sort(input);

            input.Should().Equal(1, 2, 2, 3, 4, 5, 6, 7);
        }
    }
}