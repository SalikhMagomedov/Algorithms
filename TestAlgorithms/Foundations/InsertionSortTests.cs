using System.Collections.Generic;
using Algorithms.Foundations;
using FluentAssertions;
using NUnit.Framework;

namespace TestAlgorithms.Foundations
{
    public class InsertionSortTests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Sort_SomeIntArray_SortedIntArray()
        {
            var input = new[] {2, 4, 5, 6, 1, 3};

            InsertionSort.Sort(input);

            input.Should().Equal(1, 2, 3, 4, 5, 6);
        }
        
        [Test]
        public void Sort_SomeStringList_SortedStringList()
        {
            var input = new List<string> {"B", "D", "E", "F", "A", "C"};

            InsertionSort.Sort(input);

            input.Should().Equal("A", "B", "C", "D", "E", "F");
        }
    }
}