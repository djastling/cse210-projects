using System;
class AddUpBudget{
    private double gasTotal = 0;
    private double eatingOutTotal = 0;
    private double groceriesTotal = 0;
    private double shoppingTotal = 0;
    private double subscriptionTotal = 0;
    
    public AddUpBudget(double gasTotal, double eatingOutTotal, double groceriesTotal, double shoppingTotal, double subscriptionTotal){
        this.gasTotal = gasTotal;
        this.eatingOutTotal = eatingOutTotal;
        this.groceriesTotal = groceriesTotal;
        this.shoppingTotal = shoppingTotal;
        this.subscriptionTotal = subscriptionTotal;
    }

    public void AddingUpBudget(List<Transaction> transactionList){
        foreach (Transaction line in transactionList){
            if (line.GetCategory() == "Gasoline/Fuel"){
                gasTotal += line.GetAmount();
            } else if (line.GetCategory() == "Restaurants & Dining"){
                eatingOutTotal += line.GetAmount();
            } else if (line.GetCategory() == "Groceries"){
                groceriesTotal += line.GetAmount();
            } else if (line.GetCategory() == "Shopping"){
                shoppingTotal += line.GetAmount();
            } else if (line.GetCategory() == "Clothing"){
                shoppingTotal += line.GetAmount();
            } else if (line.GetCategory() == "Dues and Subscriptions"){
                subscriptionTotal += line.GetAmount();
            }
        }

        
    }
    public double GetGasTotal(){
        return gasTotal;
    }
    public double GetEatingOutTotal(){
        return eatingOutTotal;
    }
    public double GetGroceriesTotal(){
        return groceriesTotal;
    }
    public double GetShoppingTotal(){
        return shoppingTotal;
    }
    public double GetSubscriptionTotal(){
        return subscriptionTotal;
    }
}