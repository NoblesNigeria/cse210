using System.ComponentModel.DataAnnotations;

public class Job
{
    public string _company;
    public string _jobTitle;
    public int _startYear;
    public int _endYear;
    
    {
        Job_company = "Microsoft";
        _jobTitle = "Software Engineer";
        _startYear = 2020;
        _endYear = 2023;
    }
    public void Display()
    {
        Console.WriteLine($"Company: {_company}");
        Console.WriteLine($"Job Title: {_jobTitle}");
        Console.WriteLine($"Start Year: {_startYear}");
        Console.WriteLine($"End Year: {_endYear}");
    }
}