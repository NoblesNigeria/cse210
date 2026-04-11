public class ChecklistGoal : Goal
{
    private int _target;
    private int _current;
    private int _bonus;

    public ChecklistGoal(string name, string description, int points, int target, int bonus, int current = 0)
        : base(name, description, points)
    {
        _target = target;
        _bonus = bonus;
        _current = current;
    }

    public override int RecordEvent()
    {
        _current++;
        int earned = GetPoints();

        if (_current == _target)
        {
            earned += _bonus;
        }

        return earned;
    }

    public override bool IsComplete() => _current >= _target;

    public override string GetStatus()
    {
        return $"[{(_current >= _target ? "X" : " ")}] {_current}/{_target}";
    }

    public override string SaveFormat()
    {
        return $"ChecklistGoal|{Name}|{Description}|{GetPoints()}|{_target}|{_bonus}|{_current}";
    }
}