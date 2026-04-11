public class EternalGoal : Goal
{
    private int _count;

    public EternalGoal(string name, string description, int points, int count = 0)
        : base(name, description, points)
    {
        _count = count;
    }

    public override int RecordEvent()
    {
        _count++;
        return GetPoints();
    }

    public override bool IsComplete() => false;

    public override string GetStatus()
    {
        return $"[∞] Times completed: {_count}";
    }

    public override string SaveFormat()
    {
        return $"EternalGoal|{Name}|{Description}|{GetPoints()}|{_count}";
    }
}