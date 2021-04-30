using Algorithms.Foundations;
using FluentAssertions;
using NUnit.Framework;

namespace TestAlgorithms.Foundations
{
    public class BubbleSortTests
    {
        [Test]
        public void Sort_SomeContainer_SortedContainer()
        {
            var input = new[] {2, 4, 5, 6, 1, 3};
            
            BubbleSort.Sort(input);

            input.Should().Equal(1, 2, 3, 4, 5, 6);
        }
    }
}