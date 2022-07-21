using FluentAssertions;
using SquareCounter.Abstractions;
using System.Collections.Generic;
using Xunit;

namespace SquareCounter.Tests
{
    public class AbstractionTests
    {
        [Fact]
        public void Square_should_count_square()
        {
            var figuresList = new List<IFigure>();
            var squaresList = new List<double>();

            figuresList.Add(new Circle(5));
            figuresList.Add(new Triangle(3, 4, 5));

            foreach(var figure in figuresList)
            {
                squaresList.Add(figure.Square());
            }

            var expectedResult = new List<double>()
            {
                78.53981633974483,
                6
            };

            squaresList.Should().BeEquivalentTo(expectedResult);
        }
    }
}
