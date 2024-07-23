using System;
class AFCUTransaction : InputTransaction{

    // ImportTransaction method that overrides the abstract method in the InputTransaction class
    public override void ImportTransaction(string[] allLines)
    {
        // creates a list of each row but excludes the header
        List<string> rowsWithoutHeader = new List<string>();
        for (int i = 1; i < allLines.Length; i++)
        {
            rowsWithoutHeader.Add(allLines[i]);
        }
        
        // prompts the user to input the category for each transaction
        Console.WriteLine("Please input the category for each transaction.");

        foreach (var row in rowsWithoutHeader)
        {
            // splits the row into columns
            string[] columns = ParseList(row);

            // displays the transaction details and prompts the user to input the category
            Console.WriteLine($"{columns[0]} --- ${columns[3]} --- {columns[2]}");
            string category = Console.ReadLine();

            // creates a new transaction and adds it to the transaction list
            Transaction transaction = new Transaction(columns[0], double.Parse(columns[3]), columns[2], category);
            InputTransaction.transactionList.Add(transaction);
        }
    }

    private static string[] ParseList(string row)
    {
        // splits the row into columns
        string[] columns = row.Split(new string[] { "\",\"" }, StringSplitOptions.None);

        // trims the \" off each string (not every item has the \" so it isn't included in the Split)
        for (int i = 0; i < columns.Length; i++)
        {
            columns[i] = columns[i].Trim('\"');
        }

        // if the category is empty, it sets the category to the description
        if (columns[3] == ""){
            columns[3] = columns[4];
        }

        // returns the columns
        return columns; 
    }
}