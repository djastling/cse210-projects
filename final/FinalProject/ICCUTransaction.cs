using System;
class ICCUTransaction : InputTransaction{
    public override void ImportTransaction(string[] allLines)
    {
        // creates a list of each row but excludes the header
        List<string> rowsWithoutHeader = new List<string>();
        for (int i = 1; i < allLines.Length; i++)
        {
            rowsWithoutHeader.Add(allLines[i]);
        }
        
        // loops through the list and creates a new transaction for each row
        foreach (var row in rowsWithoutHeader)
        {
            string[] columns = ParseList(row);

            Transaction transaction = new Transaction(columns[1], double.Parse(columns[4]), columns[7], columns[8]);

            InputTransaction.transactionList.Add(transaction);  // adds the transaction to the transaction list
        }
    }

    static string[] ParseList(string row){

        // splits the row into columns
        string[] columns = row.Split(new string[] { "\",\"" }, StringSplitOptions.None);

        // trims the \" off each string (not every item has the \" so it isn't included in the Split)
        for (int i = 0; i < columns.Length; i++)
        {
            columns[i] = columns[i].Trim('\"');
        }

        // returns the columns
        return columns;
    }
}