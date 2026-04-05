public class Rectangle :Shape
{
    private int _length;
    private int _side;
    public int length()
    {
        return _length;
    }
    public int Side()
    {
        return _side;
    }
    public Rectangle(int length, int side) : base("Green") // Assuming a default color
    {
        _length = length;
        _side = side;
    }
    public override double GetArea()
    {
        return _length * _side;
    }
}