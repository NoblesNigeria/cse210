public class Swimming : Sport
{
    private double _distance;
    public Swimming(string name, int date, int duration, double distance) : base(name, date, duration)
    {
        _distance = distance;
    }
    public double getDistance()
    {
        return _distance;
    }
    public override void GetSummary()
    {
        Console.WriteLine($"Sport: {getName()}, Date: {getDate()}, Duration: {getDuration()} minutes, Distance: {_distance} km");
    }
}