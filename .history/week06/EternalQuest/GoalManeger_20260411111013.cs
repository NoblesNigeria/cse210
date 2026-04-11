using System;
using System.Collections.Generic;
using System.IO;

public class GoalManager
{
    private List<Goal> _goals = new List<Goal>();
    private int _score;

    public void AddGoal(Goal goal)
    {
        _goals.Add(goal);
    }

    public void DisplayGoals()
    {
        Console.WriteLine("\nYour Goals:");
        for (int i = 0; i < _goals.Count; i++)
        {
            Goal g = _goals[i];
            Console.WriteLine($"{i + 1}. {g.GetStatus()} {g.Name}");
        }
    }

    public void RecordEvent(int index)
    {
        if (index < 0 || index >= _goals.Count) return;

        int earned = _goals[index].RecordEvent(); // polymorphism
        _score += earned;

        Console.WriteLine($"You gained {earned} points!");
    }

    public void ShowScore()
    {
        Console.WriteLine($"Total Score: {_score}");
    }

    public void Save(string file)
    {
        using (StreamWriter writer = new StreamWriter(file))
        {
            writer.WriteLine(_score);

            foreach (Goal g in _goals)
            {
                writer.WriteLine(g.SaveFormat());
            }
        }
    }

    public void Load(string file)
    {
        if (!File.Exists(file)) return;

        string[] lines = File.ReadAllLines(file);
        _score = int.Parse(lines[0]);
        _goals.Clear();

        for (int i = 1; i < lines.Length; i++)
        {
            string[] p = lines[i].Split('|');

            if (p[0] == "SimpleGoal")
                _goals.Add(new SimpleGoal(p[1], p[2], int.Parse(p[3]), bool.Parse(p[4])));

            else if (p[0] == "EternalGoal")
                _goals.Add(new EternalGoal(p[1], p[2], int.Parse(p[3]), int.Parse(p[4])));

            else if (p[0] == "ChecklistGoal")
                _goals.Add(new ChecklistGoal(p[1], p[2],
                    int.Parse(p[3]), int.Parse(p[4]),
                    int.Parse(p[5]), int.Parse(p[6])));
        }
    }
}