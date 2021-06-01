using Algorithms.Sorting;
using FluentAssertions;
using NUnit.Framework;

namespace TestAlgorithms.Sorting
{
    public class MediansAndStatisticsTests
    {
        private int[] _input;
        
        [SetUp]
        public void SetUp()
        {
            _input = new[] {9, 4, 2, 7, 1, 10, 5};
        }
        
        [Test]
        public void Minimum_SomeContainer_MinimumValueFromContainer()
        {
            _input.Minimum().Should().Be(1);
        }
        
        [Test]
        public void Maximum_SomeContainer_MaximumValueFromContainer()
        {
            _input.Maximum().Should().Be(10);
        }
    }
}