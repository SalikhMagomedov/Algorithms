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
            var array = new[] {2, 4, 5, 6, 1, 3};

            InsertionSort.Sort(array);

            array.Should().Equal(1, 2, 3, 4, 5, 6);
        }
        
        [Test]
        public void Sort_SomeStringList_SortedStringList()
        {
            var array = new List<string> {"B", "D", "E", "F", "A", "C"};

            InsertionSort.Sort(array);

            array.Should().Equal("A", "B", "C", "D", "E", "F");
        }
    }
}