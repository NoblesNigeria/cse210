public class Cycling : Sport
{
    private double _speed;
    private double _distance;
    public Cycling(string name, int date, int duration, double speed) : base(name, date, duration)
    {
        _speed = speed;
    }
    public double getSpeed()
    {
        return _speed = 
    }
    public override void GetSummary()
    {
        Console.WriteLine($"Sport: {getName()}, Date: {getDate()}, Duration: {getDuration()} minutes, Speed: {_speed} km/h");
    }
}