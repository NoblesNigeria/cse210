using System.Diagnostics.Tracing;

public class SimpleGoal : Goal
{
    public SimpleGoal(string description, int status, int setPoints, int setPeriod) : base(description, status, setPoints, setPeriod)
    {
        status = 1;
        description = "s"

    }
}