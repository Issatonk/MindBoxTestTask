using MindBox.FiguresLib.Figures;
using MindBox.FiguresLib.Interfaces;

namespace MindBox.FiguresLib;

public class ShapeFactory : IShapeFactory
{
    public IShape CreateTriangle(double sideA, double sideB, double sideC)
    {
        return new Triangle(sideA, sideB, sideC);
    }

    public IShape CreateTriangle(double[] sides)
    {
        return new Triangle(sides);
    }

    public IShape CreateCircle(double radius)
    {
        return new Circle(radius);
    }
}