using System;

namespace homework3
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Circle circle = new Circle(5);
            Circle circle2 = new Circle(3); 
            Rectangle rectangle = new Rectangle(4, 5);
            Rectangle rectangle2 = new Rectangle(2, 3);
            Square square = new Square(3);
            Square square2 = new Square(4);
            Triangle triangle = new Triangle(3, 4, 5);
            Triangle triangle2 = new Triangle(1, 2, 3);
            Triangle triangle3 = new Triangle(2, 2, 3);
            Triangle triangle4 = new Triangle(1, 1, 1);

            double area_sum = 0;
            area_sum += circle.Area;
            area_sum += circle2.Area;
            area_sum += rectangle.Area;
            area_sum += rectangle2.Area;
            area_sum += square.Area;
            area_sum += square2.Area;
            area_sum += triangle.Area;
            area_sum += triangle2.Area;
            area_sum += triangle3.Area;
            area_sum += triangle4.Area;
            Console.WriteLine("所有形状的面积之和为: " + area_sum);


        }
    }
}