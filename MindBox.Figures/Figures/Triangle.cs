using MindBox.FiguresLib.Interfaces;

namespace MindBox.FiguresLib.Figures;

public class Triangle : IShape
{
    const int NUMBER_OF_SIDES = 3;
    public double[] Sides { get; private set; }

    public Triangle(double sideA, double sideB, double sideC) : this(new double[] { sideA, sideB, sideC })
    {  }
    public Triangle(double[] sides)
    {
        if (sides == null || sides.Length != NUMBER_OF_SIDES)
        {
            throw new ArgumentException("Invalid number of sides. A triangle must have exactly three sides.");
        }
        if (sides.Where(x => x <= 0).Count() >= 1)
        {
            throw new ArgumentOutOfRangeException("Sides must be a positive value.");
        }
        if (sides[0] + sides[1] < sides[2] ||
            sides[1] + sides[2] < sides[0] ||
            sides[2] + sides[0] < sides[1])
        {
            throw new ArgumentException("Invalid values of the sides");
        }
        Sides = new double[NUMBER_OF_SIDES];
        Array.Copy(sides, Sides, NUMBER_OF_SIDES);
        Array.Sort(Sides);
    }

    public double CalculateArea()
    {
        double semiPerimeter = (Sides[0] + Sides[1] + Sides[2]) / 2;
        return Math.Sqrt(semiPerimeter *
            (semiPerimeter - Sides[0]) *
            (semiPerimeter - Sides[1]) *
            (semiPerimeter - Sides[2]));
    }

    public bool IsRightAngled()
    {
        return Math.Pow(Sides[0], 2) + Math.Pow(Sides[1], 2) == Math.Pow(Sides[2], 2);
    }
}