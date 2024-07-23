using System;
abstract class InputTransaction{

    // Creates the transaction list
    public static List<Transaction> transactionList = new List<Transaction>();
    public static void InputNewTransactions()
    {
        // Ask the user for the bank and filename
        Console.WriteLine("What bank would you like to import from? ");
        Console.WriteLine("1. ICCU");
        Console.WriteLine("2. AFCU");
        Console.WriteLine("3. HAPO");
        string bank = Console.ReadLine();
        Console.WriteLine("What is the filename?");
        string filename = Console.ReadLine();

        try{
            // tries to read the file
            string[] allLines = File.ReadAllLines(filename);
            
            // checks the bank the user entered and imports the transactions
            if (bank == "1"){
                ICCUTransaction ICCUTransaction = new ICCUTransaction();
                ICCUTransaction.ImportTransaction(allLines);

            } else if (bank == "2"){
                AFCUTransaction AFCUTransaction = new AFCUTransaction();
                AFCUTransaction.ImportTransaction(allLines);

            } else if (bank == "3"){
                HAPOTransaction HAPOTransaction = new HAPOTransaction();
                HAPOTransaction.ImportTransaction(allLines);

            } else {
                // writes an error message if the user enters an invalid bank
                Console.WriteLine("Invalid input.");
                return;
            }

            // confirmes to the user that the file was imported
            Console.WriteLine($"{filename} imported");
        } catch{

            // if the file can't be found, the program writes an error message
            Console.WriteLine("File not found.");
            return;
        }
    }
    
    // creates an abstract method to import the transaction for each bank class to override
    public abstract void ImportTransaction(string[] allLines);

    public static void DisplayTransactions(){

        // clears the console and displays the transaction categories
        Console.Clear();
        Console.WriteLine("{0,-12} {1,-10} {2,-70} {3,-15}","Date", "Amount", "Description", "Category");
        Console.WriteLine(new string('-', 110));

        // loops through the transactionList and displays each transactions
        foreach (Transaction transaction in transactionList)
        {
            string description = transaction.GetDescription();
            if (description.Length > 70)
            {
                description = description.Substring(description.Length - 70, 70);
            }

            // displays each transaction's date, amount, description, and category
            Console.WriteLine("{0,-12} {1,-10:C} {2,-70} {3, -15}", transaction.GetDate(), transaction.GetAmount(), description, transaction.GetCategory());
        }

        // waits for the user to press enter
        Console.Write("\nPress Enter to continue...");
        Console.ReadLine();
    }
}