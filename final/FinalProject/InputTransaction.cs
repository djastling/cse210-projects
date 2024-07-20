using System;
public class InputTransaction{
    public static List<Transaction> transactionList = new List<Transaction>();
    public static void InputNewTransactions(){
        Console.WriteLine("What bank would you like to import from? ");
        Console.WriteLine("1. ICCU");
        Console.WriteLine("2. AFCU");
        Console.WriteLine("3. HAPO");
        string bank = Console.ReadLine();
        Console.WriteLine("What is the filename?");
        string filename = Console.ReadLine();

        // Read all lines from the file
        string[] allLines = File.ReadAllLines(filename);

        if (bank == "1"){
            ICCUTransaction.ICCUImportTransaction(allLines);
        } else if (bank == "2"){
            AFCUTransaction.AFCUImportTransaction(allLines);
        } else if (bank == "3"){
            HAPOTransaction.HAPOImportTransaction(allLines);
        }
    }

    public static void DisplayTransactions(){

        Console.Clear();
        Console.WriteLine("{0,-12} {1,-10} {2,-70} {3,-15}","Date", "Amount", "Description", "Category");
        Console.WriteLine(new string('-', 110));
        foreach (Transaction transaction in transactionList)
        {
            string description = transaction.GetDescription();
            if (description.Length > 70)
            {
                description = description.Substring(description.Length - 70, 70);
            }
            Console.WriteLine("{0,-12} {1,-10:C} {2,-70} {3, -15}", transaction.GetDate(), transaction.GetAmount(), description, transaction.GetCategory());
        }
        Console.Write("\nPress Enter to continue...");
        Console.ReadLine();
    }

    public static string[] SplitString(string input)
    {
        string[] parts = null;
        if (input.Contains("\",\""))
        {
            parts = input.Split(new[] { "\",\"" }, StringSplitOptions.None);
            parts[0] = parts[0].TrimStart('\"');
            parts[parts.Length - 1] = parts[parts.Length - 1].TrimEnd('\"');
        }
        else if (input.Contains(","))
        {
            parts = input.Split(',');
        }
        return parts;
    }
}