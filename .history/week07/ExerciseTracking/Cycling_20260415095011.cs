public class Cycling : Sport
{
    private double _speed;
    private double _distance;
    public Cycling(string name, int date, int duration, double distance, double speed) : base(name, date, duration)
    {
        _speed = speed;
        _distance = distance;
    }
    public double GetSpeed()
    {
        return _speed = di
    }
    public double getDistance()
    {
        return _distance;
    }
    public override void GetSummary()
    {
        Console.WriteLine($"Sport: {getName()}, Date: {getDate()}, Duration: {getDuration()} minutes, Speed: {_speed} km/h");
    }
}