using System;
using Xunit;
using FluentAssertions;
using SquareCounter.Exceptions;

namespace SquareCounter.Tests
{
    public class TriangleTests
    {
        [Theory]
        [InlineData(-1, 0, 0)]
        [InlineData(15, 3, 4)]
        public void Constructor_should_throw_exception_if_triangle_is_impossible(double sideA, double sideB, double sideC )
        {
            Action a = () => new Triangle(sideA, sideB, sideC);
            a.Should().Throw<ImpossibleTriangleException>();
        }

        [Fact]
        public void Square_should_count_square_if_triangle_is_possible()
        {
            var triangle = new Triangle(3, 3, 4);

            var square = triangle.Square();

            square.Should().Be(4.47213595499958);
        }

        [Fact]
        public void Square_should_count_square_if_triangle_is_right()
        {
            var triangle = new Triangle(3, 4, 5);

            var square = triangle.Square();

            square.Should().Be(6);
        }
    }
}
