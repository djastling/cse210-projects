using System;
class HAPOTransaction : InputTransaction{
    public override void ImportTransaction(string[] allLines)
    {
        // creates a list of each row but excludes the header
        List<string> rowsWithoutHeader = new List<string>();
        for (int i = 4; i < allLines.Length; i++)
        {
            rowsWithoutHeader.Add(allLines[i]);
        }
        
        // prompts the user to input the category for each transaction
        Console.WriteLine("Please input the category for each transaction.");

        // loops through the list and creates a new transaction for each row
        foreach (var row in rowsWithoutHeader)
        {
            string[] columns = ParseList(row);

            // displays the transaction details and prompts the user to input the category
            Console.WriteLine($"{columns[1]} --- ${columns[9]} --- {columns[3]}");
            string category = Console.ReadLine();

            // creates a new transaction and adds it to the transaction list
            Transaction transaction = new Transaction(columns[1], double.Parse(columns[9]), columns[3], category);
            InputTransaction.transactionList.Add(transaction);
        }

        string[] ParseList(string row){

            // splits the row into columns
            string[] columns = row.Split(',');

            // trims the \" off each string (not every item has the \" so it isn't included in the Split)
            for (int i = 0; i < columns.Length; i++)
            {
                columns[i] = columns[i].Trim('\"');
            }

            // returns the columns
            return columns;
        }
    }
}