using System.ComponentModel.DataAnnotations;

public class Job
{
    public string _company;
    public string _jobTitle;
    public Job()
    {
        _company = "Microsoft";
        _jobTitle = "Software Engineer";
        _start
    }
    public void Display()
    {
        Console.WriteLine($"Company: {_company}");
        Console.WriteLine($"Job Title: {_jobTitle}");
    }
}