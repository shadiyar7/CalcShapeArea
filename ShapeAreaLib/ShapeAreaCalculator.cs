using ShapeAreaLib.Interfaces;

namespace ShapeAreaLib;


public class ShapeAreaCalculator
{
    public double CalculateShapeArea(IShape shape)
    {
        return shape.CalculateArea();
    }
}

