using MindBox.FiguresLib.Figures;

namespace Mindbox.Figures.Tests;

public class CircleTests
{
    [Fact]
    public void Circle_ValidRadius_CalculateArea()
    {
        // Arrange
        double radius = 2;
        Circle circle = new Circle(radius);

        // Act
        double area = circle.CalculateArea();

        // Assert
        Assert.Equal(Math.PI * 4, area);
    }

    [Fact]
    public void Circle_InvalidRadius_ThrowArgumentOutOfRangeException()
    {
        // Arrange & Act & Assert
        Assert.Throws<ArgumentOutOfRangeException>(() => new Circle(-1));
    }
}
