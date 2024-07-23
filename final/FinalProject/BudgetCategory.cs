using System;
class BudgetCategory{
    // private member variables for the budget category
    private string name;
    private string month;
    private double budgetAmount;

    // constructor for the budget category
    public BudgetCategory(string name, string month, double budgetAmount){
        this.name = name;
        this.month = month;
        this.budgetAmount = budgetAmount;
    }

    // getters for the budget category
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
