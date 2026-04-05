public class Circle : Shape
{
    private int _radius;
    public int radius()
    {
        return _radius;
    }
    public Circle(int radius) : base("b") // Assuming a default color
    {
        _radius = radius;
    }
    public override double GetArea()
    {
        return Math.PI * _radius * _radius;
    }
    public override string GetColor()
    {
        return base.GetColor();
    }
}