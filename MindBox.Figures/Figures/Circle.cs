using MindBox.FiguresLib.Interfaces;

namespace MindBox.FiguresLib.Figures;

public class Circle : IShape
{
    public double Radius { get; private set; }

    public Circle(double radius)
    {
        if (radius <= 0)
        {
            throw new ArgumentOutOfRangeException("Radius must be a positive value.");
        }

        Radius = radius;
    }

    public double CalculateArea()
    {
        return Math.PI * Math.Pow(Radius, 2);
    }
}