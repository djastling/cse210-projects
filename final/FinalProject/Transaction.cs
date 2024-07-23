using System;
public class Transaction{
    // private member variables for the transaction
    private string date;
    private double amount;
    private string description;
    private string category;

    // constructor for the transaction
    public Transaction(string date, double amount, string description, string category){
        this.date = date;
        this.description = description;
        this.amount = amount;
        this.category = category;
    }

    // getters and setters for the transaction class
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