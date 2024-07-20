using System;
public class Transaction{
    private string date;
    private double amount;
    private string description;
    private string category;

    public Transaction(string date, double amount, string description, string category){
        this.date = date;
        this.description = description;
        this.amount = amount;
        this.category = category;
    }

    public string GetDate(){
        return date;
    }
    public double GetAmount(){
        return amount;
    }
    public string GetDescription(){
        return description;
    }
    public string GetCategory(){
        return category;
    }
    public void SetCategory(string setCategory){
        category = setCategory;
    }
}