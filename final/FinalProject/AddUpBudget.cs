using System;
class AddUpBudget{
    // creates the variables for the totals
    private double rentTotal = 0;
    private double gasTotal = 0;
    private double eatingOutTotal = 0;
    private double groceriesTotal = 0;
    private double shoppingTotal = 0;
    private double subscriptionTotal = 0;
    private double utilitiesTotal = 0;
    private double medicalTotal = 0;
    private double educationTotal = 0;
    
    // creates the constructor
    public AddUpBudget(){
    }

    // adds up the budget for each category
    public void AddingUpBudget(List<Transaction> transactionList){

        // loops through the transaction list and adds the amount to the total for each category
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
            } else if (line.GetCategory() == "Utilities"){
                utilitiesTotal += line.GetAmount();
            } else if (line.GetCategory() == "Medical"){
                medicalTotal += line.GetAmount();
            } else if (line.GetCategory() == "Education"){
                educationTotal += line.GetAmount();
            } else if (line.GetCategory() == "Rent"){
                rentTotal += line.GetAmount();
            }
        }

        
    }

    // Getters for each of the categories
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
    public double GetUtilitiesTotal(){
        return utilitiesTotal;
    }
    public double GetMedicalTotal(){
        return medicalTotal;
    }
    public double GetEducationTotal(){
        return educationTotal;
    }
    public double GetRentTotal(){
        return rentTotal;
    }

}