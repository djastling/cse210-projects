using System;
public class BudgetCategory{
    private string name;
    private string month;
    private double budgetAmount;

    public BudgetCategory(string name, string month, double budgetAmount){
        this.name = name;
        this.month = month;
        this.budgetAmount = budgetAmount;
    }

    public string GetCategory(){
        return name;
    }
    public double GetAmount(){
        return budgetAmount;
    }

    public string GetMonth(){
        return month;
    }
}
