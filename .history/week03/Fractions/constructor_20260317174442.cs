using System.Diagnostics.Contracts;

public class Constructor
{
    private int _topNumber;
    private int _bottomNumber;

    public Constructor()
    {
        Console.WriteLine("Hello World! This is the Fractions Project.");
        _topNumber = 3;
        _bottomNumber = 5;

        Console.WriteLine(_topNumber / _bottomNumber);
    }
    public int getTop()
    {
        return _topNumber;
    }
    public int getBottom()
    {
        return _bottomNumber;
    }
    public int setTop(int top)
    {
        _topNumber = top;
        return _topNumber;
    }
    public int setBottom(int bottom)
    {
        _bottomNumber = bottom;
        return _bottomNumber;
    }
    ContractPublicPropertyNameAttribute 

}