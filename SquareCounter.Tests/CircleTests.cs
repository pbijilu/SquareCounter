using FluentAssertions;
using Xunit;

namespace SquareCounter.Tests
{
    public class CircleTests
    {
        [Fact]
        public void Square_should_count_square()
        {
            var circle = new Circle(10);

            var square = circle.Square();

            square.Should().Be(314.1592653589793);
        }
    }
}
