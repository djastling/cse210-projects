using System;

class Program
{
    static void Main(string[] args)
    {
        // Create a new assignment for Samuel Bennett
        Assignment assignment = new Assignment("Samuel Bennett", "Multiplication");
        Console.WriteLine(assignment.GetSummary()); // Display the current assignment

        // Create a new Math Assignment for Roberto Rodriguez
        MathAssignment MathAssignment = new MathAssignment("Roberto Rodriguez", "Fractions", "Section 7.3", "Problems 8-19");
        Console.WriteLine(MathAssignment.GetSummary()); // Display the summary
        Console.WriteLine(MathAssignment.GetHomeworkList()); // Display the math assignment

        // Create a new Writing Assignment for Mary Waters
        WritingAssignment writingAssignment = new WritingAssignment("Mary Waters", "European History", "The Causes of World War II");
        Console.WriteLine(MathAssignment.GetSummary()); // Displays the summary
        Console.WriteLine(writingAssignment.GetWritingInformation()); // Displays the Writing Assignment
    }
}