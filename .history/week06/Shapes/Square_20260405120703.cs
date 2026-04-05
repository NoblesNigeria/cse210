public class Square : Shape
{
    private int _sides;
    public int sides()
    {
        return _sides;
    }
    public Square(int sides) : base("blue") // Assuming a default color
    {
        _sides = sides;
    }
    public override double GetArea()
    {
        return _color, _sides * _sides;
    }
}