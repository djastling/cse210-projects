using System;
class SaveInformation{
    public static void SaveToFile(){

        List<BudgetCategory> budgetList = Budget.GetBudgetList();
        Console.Write("What month would you like to save to? ");
        string fileName = Console.ReadLine();
        StreamWriter writer = new StreamWriter($"{fileName}Transactions.txt");
        foreach (Transaction line in InputTransaction.transactionList){
            writer.WriteLine(line.GetDate() + "~/~" + line.GetAmount() + "~/~" + line.GetDescription() + "~/~" + line.GetCategory());
        }
        writer.Close();
        StreamWriter budgetWriter = new StreamWriter($"{fileName}Budget.txt");
        foreach (BudgetCategory line in budgetList){
            budgetWriter.WriteLine(line.GetCategory() + "~/~" + line.GetMonth() + "~/~" + line.GetAmount());
        }
        budgetWriter.Close();
        Console.WriteLine($"Transactions have been save to {fileName}Transactions.txt and Budget has been saved to {fileName}Budget.txt.");
        Console.WriteLine("Press Enter to continue...");
        Console.ReadLine();
    }
}