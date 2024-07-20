using System;
using System.ComponentModel;
class LoadInformation{
    public static List<Transaction> LoadInInformation(){
        Console.Write("What month would you like to load in? ");
        string month = Console.ReadLine();
        List<Transaction> transactionList = new List<Transaction>();

        StreamReader reader = new StreamReader($"{month}Transactions.csv");
        string line = reader.ReadLine();
        while (line != null){
            string[] parts = line.Split("~/~");
            transactionList.Add(new Transaction(parts[0], double.Parse(parts[1]), parts[2], parts[3]));
            line = reader.ReadLine();
        }
        reader.Close();
        InputTransaction.transactionList = transactionList;

        List<BudgetCategory> budgetList = new List<BudgetCategory>();

        StreamReader budgetReader = new StreamReader($"{month}Budget.csv");
        string budgetLine = budgetReader.ReadLine();
        while (budgetLine != null){
            string[] parts = budgetLine.Split("~/~");
            budgetList.Add(new BudgetCategory(parts[0], parts[1], double.Parse(parts[2])));
            budgetLine = budgetReader.ReadLine();
        }
        budgetReader.Close();
        Budget.SetBudgetList(budgetList);
        return transactionList;
    }
}