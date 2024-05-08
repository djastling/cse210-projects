using System; // Calls the System namespace, which allows us to use Console.WriteLine, strings, and other C# features

class Program // Declares a class named Program
{
    public static void Main(string[] args) // Declares a method main, which is the entry point of the program
    {
        Job job1 = new Job(); // Creates a new instance of the Job class and assigns it to the variable job1
        job1._jobTitle = "Software Engineer"; //creates member variables for job1
        job1._companyName = "BYU-Idaho";
        job1._startYear = "2020";
        job1._endYear = "2024";
        
        Job job2 = new Job();
        job2._jobTitle = "Electrical Engineer"; //creates member variables for job2
        job2._companyName = "Microsoft";
        job2._startYear = "2017";
        job2._endYear = "2021";

        Resume resume1 = new Resume(); //creates a new instance of the Resume class and assigns it to the variable resume1
        resume1._personName = "Allison Rose"; //creates a member variable for resume1

        resume1._jobList.Add(job1); //creates a member variable for resume1 and adds jobs to the list
        resume1._jobList.Add(job2);

        resume1.DisplayResume(); //calls the DisplayResume method for resume1
    }
}