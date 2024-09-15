namespace ShapeAreaLib.Tests;

using ShapeAreaLib.Shapes;
using Xunit;

public class CircleTests
{
    [Fact]
    public void Circle_CalculateArea_ReturnsCorrectArea()
    {   

        var circle = new Circle(5);
        var expectedArea = Math.PI * 25;
        Assert.Equal(expectedArea, circle.CalculateArea(), 2);
    }

    [Fact]
    public void Circle_NegativeRadius_ThrowsArgumentException()
    {
        Assert.Throws<ArgumentException>(() => new Circle(-1));
    }
}
