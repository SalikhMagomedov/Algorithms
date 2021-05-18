using Algorithms.Other;
using FluentAssertions;
using NUnit.Framework;

namespace TestAlgorithms.Other
{
    public class FindMaximumSubarrayTests
    {
        [Test]
        public void Find_SomeContainer_MaximumSubarrayIndexesAndSum()
        {
            var input = new[] {13, -3, -25, 20, -3, -16, -23, 18, 20, -7, 12, -5, -22, 15, -4, 7};

            var result = FindMaximumSubarray.Find(input);

            result.Should().Be((7, 10, 43));
        }
    }
}