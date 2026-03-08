using System;
using System.Reflection.Metadata.Ecma335;
using System.Security.Cryptography.X509Certificates;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Resumes Project.");
        Job Job1 = new Job();
        Job1._company = "Microsoft";
        Job1._jobTitle = "Software Engineer";

    }
    class Job()
    {
        public string _company;
        public string _jobTitle;
    }


}