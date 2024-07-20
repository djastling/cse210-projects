using System;
class HAPOTransaction{
    public static void HAPOImportTransaction(string[] allLines){

        List<string> rowsWithoutHeader = new List<string>();
        for (int i = 4; i < allLines.Length; i++)
        {
            rowsWithoutHeader.Add(allLines[i]);
        }
        
        Console.WriteLine("Please input the category for each transaction.");
        foreach (var row in rowsWithoutHeader)
        {

            string[] columns = row.Split(',');

            for (int i = 0; i < columns.Length; i++)
            {
                columns[i] = columns[i].Trim('\"');
            }

            Console.WriteLine($"{columns[1]} --- ${columns[9]} --- {columns[3]}");
            string category = Console.ReadLine();

            Transaction transaction = new Transaction(columns[1], double.Parse(columns[9]), columns[3], category);
            InputTransaction.transactionList.Add(transaction);
        }
    }
}