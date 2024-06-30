public class ChecklistGoal : Goal
{
    public int goalBonus;
    public int goalBonusPoints;
    public int completionCount;

    public ChecklistGoal(string goalName, string goalDescription, int goalPoints, int goalBonus, int goalBonusPoints) : base("Checklist Goal", goalName, goalDescription, goalPoints)
    {
        this.goalBonus = goalBonus;
        this.goalBonusPoints = goalBonusPoints;
        this.completionCount = 0;
    }

    public override int RecordEvent()
    {
        completionCount++;
        if (completionCount >= goalBonus)
        {
            return goalPoints + goalBonusPoints;
        }
        return goalPoints;
    }

    public static ChecklistGoal CreateNewGoal()
    {
        Console.Write("What is the name of your goal? ");
        string goalName = Console.ReadLine();
        Console.Write("What is a short description of your goal? ");
        string goalDescription = Console.ReadLine();
        Console.Write("What is the amount of points associated with this goal? ");
        int goalPoints = int.Parse(Console.ReadLine());
        Console.Write("How many completions are required for a bonus? ");
        int goalBonus = int.Parse(Console.ReadLine());
        Console.Write("How many bonus points are awarded? ");
        int goalBonusPoints = int.Parse(Console.ReadLine());

        return new ChecklistGoal(goalName, goalDescription, goalPoints, goalBonus, goalBonusPoints);
    }

    public override string LoadFormat()
    {
        return $"{goalType}~{goalName}~{goalDescription}~{goalPoints}~{goalBonus}~{goalBonusPoints}";
    }

    public override void DisplayGoalList()
    {
        Console.WriteLine($"[ ] {goalName} ({goalDescription}) Completed ({completionCount}/{goalBonus}) times.");
    }
}