using System;
using System.Collections.Generic;
using System.Linq;
using Algorithms.Sorting;
using FluentAssertions;
using NUnit.Framework;

namespace TestAlgorithms.Sorting
{
    public class MediansAndStatisticsTests
    {
        private int[] _input;
        private List<int> _sortedInput;
        private Random _random;

        [SetUp]
        public void SetUp()
        {
            _input = new int[11];
            _random = new Random(314);

            for (var i = 0; i < _input.Length; i++)
            {
                _input[i] = _random.Next(1, 101);
            }
            
            _sortedInput = _input.ToList();
            _sortedInput.Sort();
        }

        [Test]
        public void Minimum_SomeContainer_MinimumValueFromContainer()
        {
            _input.Minimum().Should().Be(_sortedInput[0]);
        }

        [Test]
        public void Maximum_SomeContainer_MaximumValueFromContainer()
        {
            _input.Maximum().Should().Be(_sortedInput[^1]);
        }

        [Test]
        public void RandomizedSelect_SomeContainer_SecondMinimumValueFromContainer()
        {
            var input = new int[_input.Length];
            
            _input.CopyTo(input, 0);
            
            input.RandomizedSelect(2, _random).Should().Be(_sortedInput[1]);
        }
    }
}