using System;
using System.IO; 


class Menu
{
    public static int points = 0;
    public static List<Goal> goalList = new List<Goal>();

    public static void WhileLoop(){

        string input = "";
        while (input != "7"){
            DisplayMenu(points);
            input = Console.ReadLine();


            switch (input)
            {
                case "1":
                    goalList.Add(CreateGoal());
                    break;
                case "2":
                    ListAllGoals();
                    break;
                case "3":
                    SaveGoals();
                    break;
                case "4":
                    LoadGoals();
                    break;
                case "5":
                    RecordGoal();
                    break;
                case "6":
                    MissedGoal();
                    break;
                case "7":
                    Console.WriteLine("Good bye! Keep working on your goals");
                    break;
                default:
                    Console.WriteLine("Invalid choice");
                    break;
            }
        }
    }

    public static void DisplayMenu(int points)
    {
        Console.WriteLine($"You have {points} points.\n");
        Console.WriteLine("Menu Options:");
        Console.WriteLine("1. Create New Goal");
        Console.WriteLine("2. List Goals");
        Console.WriteLine("3. Save Goals");
        Console.WriteLine("4. Load Goals");
        Console.WriteLine("5. Record Event");
        Console.WriteLine("6. Missed Event");
        Console.WriteLine("7. Quit");
        Console.Write("Select a choice from the menu: ");
    }

    public static void ListAllGoals()
    {
        int i = 1;
        foreach (Goal goal in goalList)
        {
            Console.Write($"{i}. ");
            goal.DisplayGoalList();
            i++;
        }
    }

    public static Goal CreateGoal(){

        Console.WriteLine("The types of Goals are:");
        Console.WriteLine("  1. Simple Goal");
        Console.WriteLine("  2. Eternal Goal");
        Console.WriteLine("  3. Checklist Goal");
        Console.Write("Which type of goal would you like to create? ");
        string goalType = Console.ReadLine();

        switch (goalType)
        {
            case "1":
                return SimpleGoal.CreateNewGoal();
            case "2":
                return EternalGoal.CreateNewGoal(); 
            case "3":
                return ChecklistGoal.CreateNewGoal();
            default:
                return SimpleGoal.CreateNewGoal();
        }

        

    }

    public static void SaveGoals(){

        using (StreamWriter outputFile = new StreamWriter("goals.txt"))
        {
            foreach (Goal goal in goalList){
                outputFile.WriteLine(goal.LoadFormat());
            }
        }
    }

    public static void LoadGoals(){
        using (StreamReader inputFile = new StreamReader("goals.txt"))
        {
            string line;
            while ((line = inputFile.ReadLine()) != null)
            {
                string[] parts = line.Split('~');
                switch (parts[0])
                {
                    case "Simple Goal":
                        goalList.Add(new SimpleGoal(parts[1], parts[2], int.Parse(parts[3])));
                        break;
                    case "Eternal Goal":
                        goalList.Add(new EternalGoal(parts[1], parts[2], int.Parse(parts[3])));
                        break;
                    case "Checklist Goal":
                        goalList.Add(new ChecklistGoal(parts[1], parts[2], int.Parse(parts[3]), int.Parse(parts[4]), int.Parse(parts[5])));
                        break;
                    default:
                        goalList.Add(new SimpleGoal(parts[1], parts[2], int.Parse(parts[3])));
                        break;
                }
            }
        }
    }

    public static void RecordGoal()
    {
        ListAllGoals();
        Console.Write("Which goal did you accomplish? ");
        int input = int.Parse(Console.ReadLine());
        Goal goal = goalList[input -1];
        switch (goal.goalType)
        {
            case "Checklist Goal":
                points += goal.RecordEvent();
                break;
            case "Simple Goal":
                points += goal.RecordEvent();
                goalList.Remove(goal);
                break;
            case "Eternal Goal":
                points += goal.RecordEvent();
                break;
        }
    }

    public static void MissedGoal()
    {
        ListAllGoals();
        Console.Write("Which goal did you miss? ");
        int input = int.Parse(Console.ReadLine());
        Goal goal = goalList[input - 1];
        points -= goal.RecordEvent();

        Console.Write("Would you like to continue trying to achieve this goal? Enter Y/N: ");
        string answer = Console.ReadLine();
        if (answer == "N")
        {
            goalList.Remove(goal);
            Console.Write("Thats okay, would you like to readjust your goal? Enter Y/N: ");
            string readjust = Console.ReadLine();
            if (readjust == "Y")
            {
                goalList.Add(CreateGoal());
            } else {
                Console.WriteLine("Goals are important! Try again when you feel ready.");
            }
        } else {
            Console.WriteLine("Keep working on it, you can do it!");
        }

    }
}