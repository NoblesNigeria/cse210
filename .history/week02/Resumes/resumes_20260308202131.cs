using System;

public class Resume
{
    public string _name;
    public List<string> _resumes;

    public Resume()
    {
        _name = "John Doe";
        _resumes = new List<string>();
        _resumes.Add("Software Engineer");
        _resumes.Add("Data Analyst");
        
    }

    public void Display()
    {
        Console.WriteLine($"Name: {_name}");
        Console.WriteLine("Resumes:");

        foreach (var resume in _resumes)
        {
            Console.WriteLine(resume);
        }
    }
}