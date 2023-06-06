namespace MindBox.FiguresLib.Interfaces;

public interface IShapeFactory
{
    IShape CreateTriangle(double sideA, double sideB, double sideC);
    IShape CreateTriangle(double[] sides);
    IShape CreateCircle(double radius);
}
