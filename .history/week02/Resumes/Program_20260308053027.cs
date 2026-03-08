using System;
using System.Reflection.Metadata.Ecma335;
using System.Security.Cryptography.X509Certificates;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Resumes Project.");
        Job job1 = new Job();
        job1._company = "Microsoft";
        job1._jobTitle = "Software Engineer";

        job1.Display();
    }
    class Job
    {
        public string _company;
        public string _jobTitle;
        public int _startYear;
        public int _endYear;
        public Job()
        {
            _company = "Microsoft";
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


}