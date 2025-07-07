using System;
public class Job
{
    public string _jobTitle = "Software Engineer";
    public string _companyName = "Tech Solutions";
    public int _startYear = 2020;
    public int _endYear = 2023;
    public void DisplayJobDetails()
    {
        Console.WriteLine("Job Title: " + _jobTitle);
        Console.WriteLine("Company: " + _companyName);
        Console.WriteLine("Start Year: " + _startYear);
        Console.WriteLine("End Year: " + _endYear);
    }
}
