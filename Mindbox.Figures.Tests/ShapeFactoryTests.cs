using MindBox.FiguresLib;
using MindBox.FiguresLib.Figures;
using MindBox.FiguresLib.Interfaces;

namespace Mindbox.Figures.Tests;

public class ShapeFactoryTests
{
    [Fact]
    public void CreateShape_Triangle_ReturnsTriangleInstance()
    {
        // Arrange
        var factory = new ShapeFactory();
        double[] sides = { 3, 4, 5 };

        // Act
        IShape shape = factory.CreateTriangle(sides);

        // Assert
        Assert.IsType<Triangle>(shape);
    }

    [Fact]
    public void CreateShape_Circle_ReturnsCircleInstance()
    {
        // Arrange
        var factory = new ShapeFactory();
        double radius = 5;

        // Act
        IShape shape = factory.CreateCircle(radius);

        // Assert
        Assert.IsType<Circle>(shape);
    }

    [Fact]
    public void CreateShape_InvalidSides_ThrowsArgumentException()
    {
        // Arrange
        var factory = new ShapeFactory();
        double[] sides = { 1, 2, 10 };

        // Act & Assert
        Assert.Throws<ArgumentException>(() => factory.CreateTriangle(sides));
    }

    [Fact]
    public void CreateShape_NegativeRadius_ThrowsArgumentOutOfRangeException()
    {
        // Arrange
        var factory = new ShapeFactory();
        double radius = -2;

        // Act & Assert
        Assert.Throws<ArgumentOutOfRangeException>(() => factory.CreateCircle(radius));
    }
    [Fact]
    public void CreateShape_NegativeSide_ThrowsArgumentOutOfRangeException()
    {
        // Arrange
        var factory = new ShapeFactory();
        double[] sides = { 2, -3, 4 };

        // Act & Assert
        Assert.Throws<ArgumentOutOfRangeException>(() => factory.CreateTriangle(sides));
    }
}
