public class EternalGoal : Goal
{
    public EternalGoal(string goalName, string goalDescription, int goalPoints) : base("Eternal Goal", goalName, goalDescription, goalPoints)
    {
    }

    public override int RecordEvent()
    {
        return goalPoints;
    }

    public static EternalGoal CreateNewGoal()
    {
        Console.Write("What is the name of your goal? ");
        string goalName = Console.ReadLine();
        Console.Write("What is a short description of your goal? ");
        string goalDescription = Console.ReadLine();
        Console.Write("What is the amount of points associated with this goal? ");
        int goalPoints = int.Parse(Console.ReadLine());

        return new EternalGoal(goalName, goalDescription, goalPoints);
    }

    public override string LoadFormat()
    {
        return $"{goalType}~{goalName}~{goalDescription}~{goalPoints}";
    }

    public override void DisplayGoalList()
    {
        Console.WriteLine($"[ ] {goalName} ({goalDescription})");
    }
}