using System;
using System.Reflection.Metadata.Ecma335;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Resumes Project.");
        job1 job1 = new job1();
        Console.WriteLine($"I work at {job1._company} as a {job1._jobTitle}.");

    }
    public class job1
    {
        public string _company;
        public string _jobTitle;
        public job1()
        {
            _company = "Microsoft";
            _jobTitle = "Software Engineer";
        }
    }
}