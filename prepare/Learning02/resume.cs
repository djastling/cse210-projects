using System; // Calls the System namespace, which allows us to use Console.WriteLine, strings, and other C# features

public class Resume // Delares a class called Resume
{
    public string _personName; // Declares a public string variable called _personName
    public List<Job> _jobList = new List<Job>(); // Creates and initializes a List of objects called _jobList

    public void DisplayResume() // Declares a method called DisplayResume
    {
        Console.WriteLine($"Name: {_personName}\nJobs:"); // Writes the person's name and Jobs: to the console
        for (int i = 0; i < _jobList.Count; i++) // Loops through the List _jobList for each item in jobList
        {
            _jobList[i].DisplayJobDetails(); // for each item in jobList, calls the DisplayJobDetails method
        }
    }
}