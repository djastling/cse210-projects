using System;
class Transaction{
    // private member variables for the transaction
    private string _date;
    private double _amount;
    private string _description;
    private string _category;

    // constructor for the transaction
    public Transaction(string date, double amount, string description, string category){
        _date = date;
        _description = description;
        _amount = amount;
        _category = category;
    }

    // getters and setters for the transaction class
    public string GetDate(){
        return _date;
    }
    public double GetAmount(){
        return _amount;
    }
    public string GetDescription(){
        return _description;
    }
    public string GetCategory(){
        return _category;
    }
    public void SetCategory(string setCategory){
        _category = setCategory;
    }
}