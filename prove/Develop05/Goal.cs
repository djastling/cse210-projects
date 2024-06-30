using System;
public abstract class Goal{
    public string goalType;
    public string goalName;
    public string goalDescription;
    public int goalPoints;
    

    public Goal (string goalType, string goalName, string goalDescription, int goalPoints){
        this.goalType = goalType;
        this.goalName = goalName;
        this.goalDescription = goalDescription;
        this.goalPoints = goalPoints;
    }

    public abstract int RecordEvent();

    public abstract void DisplayGoalList();

    public abstract string LoadFormat();

    public void SetGoalType(string goalType){
        this.goalType = goalType;
    }
}