public class Cycling : Sport
{
    private double _speed;
    public Cycling(string name, int date, int duration, double speed) : base(name, date, duration)
    {
        _speed = speed;
    }
    public double getSpeed()
    {
        return _speed;
    }
    public override void GetSummary()
    {
        Console.WriteLine($"Sport: {getName()}, Date: {getDate()}, Duration: {getDuration()} minutes, Distance: {_distance} km");
    }
}