using Algorithms.Other;
using FluentAssertions;
using NUnit.Framework;

namespace TestAlgorithms.Other
{
    public class SquareMatrixMultiplicationAlgorithmsTests
    {
        [Test]
        public void SquareMatrixMultiplication_Matrix_SquaredMatrix()
        {
            var matrix = new[,] {{1, 2}, {3, 4}};

            var result = SquareMatrixMultiplicationAlgorithm.SquareMatrixMultiplication(matrix, matrix);

            result.Should().Equal(7, 10, 15, 22);
        }

        [Test]
        public void SquareMatrixMultiplicationRecursive_Matrix_SquaredMatrix()
        {
            var matrix = new[,] {{1, 2}, {3, 4}};

            var result = SquareMatrixMultiplicationAlgorithm.SquareMatrixMultiplicationRecursive(matrix, matrix);

            result.Should().Equal(7, 10, 15, 22);
        }
    }
}