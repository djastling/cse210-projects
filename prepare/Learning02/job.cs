using System;

public class Job // Declares a class called Job
{
    public string _companyName; // Declares member variables in the Job class
    public string _jobTitle;
    public string _startYear;
    public string _endYear;

    public void DisplayJobDetails() // Declares a method to display the job details
    {
        Console.WriteLine($"{_jobTitle} ({_companyName}) {_startYear}-{_endYear}");
    }
}