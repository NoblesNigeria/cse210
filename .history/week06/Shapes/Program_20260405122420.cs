using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Shapes Project.");
        List<Shape> shapes = new List<Shape>();
        shapes.Add(new Circle(5));
        shapes.Add(new Rectangle(4, 6));
    }
}