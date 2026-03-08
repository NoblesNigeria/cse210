using System;
using System.Reflection.Metadata.Ecma335;
using System.Security.Cryptography.X509Certificates;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Resumes Project.");
        Job.Display();
    }
    class Job()
    {
        public string _company;
        public string _jobTitle;

    }


}