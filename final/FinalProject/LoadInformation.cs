using System;
class LoadInformation{

    // Method that loads information from a file
    public static void LoadInInformation(){

        // Asks the user for the month they would like to load in
        Console.Write("What month would you like to load in? ");
        string month = Console.ReadLine();

        // creates a list to hold the transactions
        List<Transaction> transactionList = new List<Transaction>();

        try
        {
            // tries to read the transaction file
            StreamReader reader = new StreamReader($"{month}Transactions.csv");
            string line = reader.ReadLine();

            // loops through the file and creates a new transaction for each line
            while (line != null){
                string[] parts = line.Split("~/~");
                transactionList.Add(new Transaction(parts[0], double.Parse(parts[1]), parts[2], parts[3]));
                line = reader.ReadLine();
            }
            reader.Close();

            // sets the transaction list
            InputTransaction.transactionList = transactionList;

            // confirms to the user that the transactions were loaded
            Console.WriteLine("Transactions loaded successfully.");
        }
        catch (FileNotFoundException)
        {   
            // if the file can't be found, the program displays an error message
            Console.WriteLine("Transaction file not found.");
        }

        // creates a list to hold the budget categories
        List<BudgetCategory> budgetList = new List<BudgetCategory>();
        try 
        {
            // tries to read the budget file
            StreamReader budgetReader = new StreamReader($"{month}Budget.csv");
            string budgetLine = budgetReader.ReadLine();

            // loops through the file and creates a new budget category for each line
            while (budgetLine != null){
                string[] parts = budgetLine.Split("~/~");
                budgetList.Add(new BudgetCategory(parts[0], parts[1], double.Parse(parts[2])));
                budgetLine = budgetReader.ReadLine();
            }
            budgetReader.Close();

            // sets the budget list
            Budget.SetBudgetList(budgetList);

            // confirms to the user that the budget was loaded
            Console.WriteLine("Budget loaded successfully.");
        }
        catch (FileNotFoundException){

            // if the file can't be found, the program displays an error message
            Console.WriteLine("budget File not found.");
        }
    }
}
