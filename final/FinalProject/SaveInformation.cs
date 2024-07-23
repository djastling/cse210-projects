using System;
class SaveInformation{

    // Method to save the transaction and budget information to a file
    public static void SaveToFile()
    {
        // creates a list to hold the budget categories
        List<BudgetCategory> budgetList = Budget.GetBudgetList();

        // Prompts the user to input the month they would like to save
        Console.Write("What month would you like to save to? ");
        string fileName = Console.ReadLine();

        // Checks if the user has inputted any transactions
        if (InputTransaction.transactionList.Count != 0){

            // Loops through the transactionList and writes each line to a file seperated by ~/~
            StreamWriter writer = new StreamWriter($"{fileName}Transactions.csv");
            foreach (Transaction line in InputTransaction.transactionList){
                writer.WriteLine(line.GetDate() + "~/~" + line.GetAmount() + "~/~" + line.GetDescription() + "~/~" + line.GetCategory());
            }
            writer.Close();

            // Confirms to the user that the transactions have been saved
            Console.Write($"Transactions have been saved to {fileName}Transactions.csv ");
        }

        // prints an and if there are transaction and budget files
        if (InputTransaction.transactionList.Count != 0 && budgetList.Count != 0){
            Console.Write("and");
        }

        // Checks if the user has inputted any budget categories
        if (budgetList.Count != 0){

            // Loops through the budgetList and writes each line to a file seperated by ~/~
            StreamWriter budgetWriter = new StreamWriter($"{fileName}Budget.csv");
            foreach (BudgetCategory line in budgetList){
                budgetWriter.WriteLine(line.GetCategory() + "~/~" + line.GetMonth() + "~/~" + line.GetAmount());
            }
            budgetWriter.Close();

            // Confirms to the user that the budget has been saved
            Console.Write($"Budget has been saved to {fileName}Budget.csv.");
        }

        // Confirms to the user that the files have been saved and waits for user to press enter
        Console.WriteLine();
        Console.WriteLine("Press Enter to continue...");
        Console.ReadLine();
    }
}