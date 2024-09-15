namespace ShapeAreaLib.Tests
{
    using ShapeAreaLib.Shapes;
    using Xunit;

    public class TriangleTests
    {
        [Fact]
        public void Triangle_CalculateArea_ReturnsCorrectArea()
        {
            var triangle = new Triangle(3, 4, 5);
            var expectedArea = 6;
            Assert.Equal(expectedArea, triangle.CalculateArea(), 2);
        }

        [Fact]
        public void Triangle_IsRightTriangle_ReturnsTrue()
        {
            var triangle = new Triangle(3, 4, 5);
            Assert.True(triangle.IsRightTriangle());
        }

        [Fact]
        public void Triangle_InvalidSides_ThrowsArgumentException()
        {
            Assert.Throws<ArgumentException>(() => new Triangle(1, 1, 10));
        }
    }

}
