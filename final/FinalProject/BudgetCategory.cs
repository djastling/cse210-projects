using System;
class BudgetCategory{
    // private member variables for the budget category
    private string _name;
    private string _month;
    private double _budgetAmount;

    // constructor for the budget category
    public BudgetCategory(string name, string month, double budgetAmount){
        _name = name;
        _month = month;
        _budgetAmount = budgetAmount;
    }

    // getters for the budget category
    public string GetCategory(){
        return _name;
    }
    public double GetAmount(){
        return _budgetAmount;
    }

    public string GetMonth(){
        return _month;
    }
}
