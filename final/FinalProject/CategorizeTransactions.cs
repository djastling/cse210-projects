using System;
class CategorizeTransactions{
    public static void categorize(){

        Console.WriteLine("Here are the transactions that haven't been categorized:\n");
        foreach (Transaction transaction in InputTransaction.transactionList)
        {
            if (transaction.GetCategory() == "N/A"){
                Console.WriteLine("Date: " + transaction.GetDate());
                Console.WriteLine("Amount: " + transaction.GetAmount());
                Console.WriteLine("Description: " + transaction.GetDescription());
                Console.WriteLine();
                Console.WriteLine("What is the category for this transaction? ");
                string category = Console.ReadLine();
                transaction.SetCategory(category);
            }
        }
    }
}