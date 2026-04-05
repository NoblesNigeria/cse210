public class Square : Shape
{
    private int _sides;
    public int sides()
    {
        return _sides;
    }
    public S(int sides)
    {
        _sides = sides;
    }
    public override double GetArea()
    {
        return _sides * _sides;
    }
}