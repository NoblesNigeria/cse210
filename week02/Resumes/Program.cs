using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Resumes Project.");
    }
    public string job()
    {
        Job job1 = new Job();
        job1.DisplayJobDetails();
        return "Job details displayed successfully.";
    }
    public string _jobTitle = "Software Engineer";
    public string _companyName = "Tech Solutions";
    public int _startYear = 2020;
    public int _endYear = 2023;

    public void JobInformations();
    {
        Console.WriteLine("Job Title: " + job1._jobTitle);
        Console.WriteLine("Company: " + job1._companyName);
        Console.WriteLine("Start Year: " + job1._startYear);
        Console.WriteLine("End Year: " + job1._endYear);
    }
}