using MindBox.FiguresLib.Figures;


namespace Mindbox.Figures.Tests;

public class TriangleTests
{
    [Fact]
    public void Triangle_ValidSides_CalculateArea()
    {
        // Arrange
        double[] sides = { 3, 4, 5 };
        Triangle triangle = new Triangle(sides);

        // Act
        double area = triangle.CalculateArea();

        // Assert
        Assert.Equal(6, area);
    }

    [Theory]
    [InlineData(1, 2, 10)]
    [InlineData(10, 1, 2)]
    [InlineData(1, 10, 2)]
    public void Triangle_InvalidSides_ThrowArgumentException(double sideA, double sideB, double sideC)
    {
        // Arrange
        double[] sides = { sideA, sideB, sideC };

        // Act & Assert
        Assert.Throws<ArgumentException>(() => new Triangle(sides));
    }

    [Theory]
    [InlineData(3, 4, 5)]
    [InlineData(5, 4, 3)]
    [InlineData(3, 5, 4)]
    public void Triangle_RightAngled_IsRightAngled(double sideA, double sideB, double sideC)
    {
        // Arrange
        double[] sides = { sideA, sideB, sideC };
        Triangle triangle = new Triangle(sides);

        // Act
        bool isRightAngled = triangle.IsRightAngled();

        // Assert
        Assert.True(isRightAngled);
    }

    [Fact]
    public void Triangle_NotRightAngled_IsNotRightAngled()
    {
        // Arrange
        double[] sides = { 2, 3, 4 };
        Triangle triangle = new Triangle(sides);

        // Act
        bool isRightAngled = triangle.IsRightAngled();

        // Assert
        Assert.False(isRightAngled);
    }
    [Theory]
    [InlineData(-3, 4, 5)]
    [InlineData(5, -4, 3)]
    [InlineData(3, 5, -4)]
    public void Triangle_NegativeSides_ThrowArgumentOutOfRangeException(double sideA, double sideB, double sideC)
    {
        // Arrange
        double[] sides = { sideA, sideB, sideC };

        // Act & Assert
        Assert.Throws<ArgumentOutOfRangeException>(() => new Triangle(sides));
    }


}
