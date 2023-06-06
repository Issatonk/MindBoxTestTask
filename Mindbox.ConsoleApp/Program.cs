using MindBox.FiguresLib;
using MindBox.FiguresLib.Figures;
using MindBox.FiguresLib.Interfaces;

namespace Mindbox.ConsoleApp
{
    public class Program
    {
        private static void Main(string[] args)
        {
            IShapeFactory factory = new ShapeFactory();

            while (true)
            {
                try
                {
                    Console.WriteLine("Select the type of figure: 1-triangle, 2-circle (or enter 0 to exit)");
                    int.TryParse(Console.ReadLine(), out int figureType);

                    if (figureType == 0)
                    {
                        break; 
                    }
                    else if (figureType == 1)
                    {
                        Console.WriteLine("Enter the sides of the triangle in any order separated by a space");
                        var sides = Console.ReadLine()
                            .Trim()
                            .Split(' ')
                            .Select(x => Convert.ToDouble(x))
                            .ToArray();

                        var shape = factory.CreateTriangle(sides);
                        Console.WriteLine("Area of the triangle = {0}", shape.CalculateArea());

                        if (shape is Triangle triangle)
                        {
                            bool isRightAngled = triangle.IsRightAngled();
                            Console.WriteLine($"Is Right Angled: {isRightAngled}");
                        }
                    }
                    else if (figureType == 2)
                    {
                        Console.WriteLine("Enter the radius of the circle");
                        double radius = Convert.ToDouble(Console.ReadLine());

                        var shape = factory.CreateCircle(radius);

                        Console.WriteLine("Area of the circle = {0}", shape.CalculateArea());
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"An error occurred: {ex.Message}\nTry again!");
                }
            }
        }
    }
}
