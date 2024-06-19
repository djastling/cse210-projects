using System;

class Program
{
    static void Main(string[] args)
    {
        List<Shape> shapes = new List<Shape>(){
            new Square(5, "red"),
            new Rectangle(5, 10, "blue"),
            new Circle(5, "green")
        };
        foreach (Shape shape in shapes)
        {
            Console.WriteLine($"The color is: {shape.GetColor()}, and the area is {shape.GetArea()}");
        }
    }
}