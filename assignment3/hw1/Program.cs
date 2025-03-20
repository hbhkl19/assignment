using System;
using System.Drawing;
public interface IShape
{
    double CalculateArea();
    bool Validate();
}

public abstract class ShapeBase : IShape
{
    public abstract double CalculateArea();
    public abstract bool Validate();

    protected void CheckValidity()
    {
        if (!Validate())
            throw new InvalidOperationException("Invalid shape operation");
    }
}

public class Rectangle : ShapeBase
{
    public double Length { get; set; }
    public double Width { get; set; }

    public Rectangle(double length, double width)
    {
        Length = length;
        Width = width;
    }

    public override double CalculateArea()
    {
        CheckValidity();
        return Length * Width;
    }

    public override bool Validate()
    {
        return Length > 0 && Width > 0;
    }
}

public class Square : ShapeBase
{
    public double Side { get; set; }

    public Square(double side)
    {
        Side = side;
    }

    public override double CalculateArea()
    {
        CheckValidity();
        return Side * Side;
    }

    public override bool Validate()
    {
        return Side > 0;
    }
}

public class Triangle : ShapeBase
{
    public double SideA { get; set; }
    public double SideB { get; set; }
    public double SideC { get; set; }

    public Triangle(double a, double b, double c)
    {
        SideA = a;
        SideB = b;
        SideC = c;
    }

    public override double CalculateArea()
    {
        CheckValidity();
        double s = (SideA + SideB + SideC) / 2;
        return Math.Sqrt(s * (s - SideA) * (s - SideB) * (s - SideC));
    }

    public override bool Validate()
    {
        bool sidesValid = SideA > 0 && SideB > 0 && SideC > 0;
        bool triangleInequality =
            (SideA + SideB > SideC) &&
            (SideA + SideC > SideB) &&
            (SideB + SideC > SideA);

        return sidesValid && triangleInequality;
    }
}

class Program
{
    static void Main()
    {
        try
        {
            Rectangle rect = new Rectangle(5, 3);
            Console.WriteLine($"Rectangle Area: {rect.CalculateArea()}");
            Console.WriteLine($"Is Valid: {rect.Validate()}\n");

            Square square = new Square(4);
            Console.WriteLine($"Square Area: {square.CalculateArea()}");
            Console.WriteLine($"Is Valid: {square.Validate()}\n");

            Triangle triangle = new Triangle(3, 4, 5);
            Console.WriteLine($"Triangle Area: {triangle.CalculateArea():F2}");
            Console.WriteLine($"Is Valid: {triangle.Validate()}\n");

            // 测试无效形状
            Triangle invalidTriangle = new Triangle(1, 1, 3);
            Console.WriteLine(invalidTriangle.CalculateArea());
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error: {ex.Message}");
        }
    }
}



public static class ShapeFactory
{
    private static Random random = new Random();

    public static IShape CreateRandomShape()
    {
        int shapeType = random.Next(0, 3);

        switch (shapeType)
        {
            case 0: // 长方形
                return new Rectangle(
                    random.NextDouble() * 10 + 1,
                    random.NextDouble() * 10 + 1);

            case 1: // 正方形
                return new Square(
                    random.NextDouble() * 10 + 1);

            case 2: // 三角形
                double a, b, c;
                double[] sides;
                do
                {
                    a = random.NextDouble() * 10 + 1;
                    b = random.NextDouble() * 10 + 1;
                    c = random.NextDouble() * 10 + 1;
                    sides = new double[] { a, b, c };
                    Array.Sort(sides);
                }
                while (sides[2] >= sides[0] + sides[1]);
                return new Triangle(a, b, c);

            default:
                throw new InvalidOperationException();
        }
    }
}