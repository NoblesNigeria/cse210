using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Shapes Project.");
        Square square = new Square(5);
        Console.WriteLine($"The area of the square is: {square.GetArea()}");
        
    }
}