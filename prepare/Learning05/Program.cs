using System;

class Program
{
    static void Main(string[] args)
    {
        List<Shape> shapes = new List<Shape>();

        Square square = new Square(5,"blue");
        shapes.Add(square);

        Rectangle rectangle = new Rectangle(6,2,"green");
        shapes.Add(rectangle);

        Circle circle = new Circle(4.2, "purple");
        shapes.Add(circle);

        foreach (Shape shape in shapes)
        {
            string color = shape.GetColor();
            double area = shape.GetArea();

            Console.WriteLine($"The {color} shape has an area of {area}. ");
        }

    }
}