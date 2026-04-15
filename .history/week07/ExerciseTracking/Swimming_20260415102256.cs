public class Swimming : Sport
{
    private double _distance;
    private double 
    public Swimming(string name, int date, int duration, double distance) : base(name, date, duration)
    {
        _distance = distance;
    }
    public double GetDistance()
    {
        return _distance;
    }
    public override void GetSummary()
    {
        Console.WriteLine($"Sport: {GetName()}, Date: {GetDate()}, Duration: {GetDuration()} minutes, Distance: {_distance} km");
    }
}