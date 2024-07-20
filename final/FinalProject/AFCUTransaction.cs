using System;
class AFCUTransaction{
    public static void AFCUImportTransaction(string[] allLines){

        List<string> rowsWithoutHeader = new List<string>();
        for (int i = 1; i < allLines.Length; i++)
        {
            rowsWithoutHeader.Add(allLines[i]);
        }
        
        Console.WriteLine("Please input the category for each transaction.");
        foreach (var row in rowsWithoutHeader)
        {
            string[] columns = row.Split(new string[] { "\",\"" }, StringSplitOptions.None);

            for (int i = 0; i < columns.Length; i++)
            {
                columns[i] = columns[i].Trim('\"');
            }

            if (columns[3] == ""){
                columns[3] = columns[4];
            }

            Console.WriteLine($"{columns[0]} --- ${columns[3]} --- {columns[2]}");
            string category = Console.ReadLine();

            Transaction transaction = new Transaction(columns[0], double.Parse(columns[3]), columns[2], category);
            InputTransaction.transactionList.Add(transaction);
        }
    }
}