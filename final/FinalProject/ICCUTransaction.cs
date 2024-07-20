using System;
public class ICCUTransaction{
    public static void ICCUImportTransaction(string[] allLines){

        List<string> rowsWithoutHeader = new List<string>();
        for (int i = 1; i < allLines.Length; i++)
        {
            rowsWithoutHeader.Add(allLines[i]);
        }
        
        foreach (var row in rowsWithoutHeader)
        {
            string[] columns = row.Split(new string[] { "\",\"" }, StringSplitOptions.None);

            for (int i = 0; i < columns.Length; i++)
            {
                columns[i] = columns[i].Trim('\"');
            }

            Transaction transaction = new Transaction(columns[1], double.Parse(columns[4]), columns[7], columns[8]);
            InputTransaction.transactionList.Add(transaction);
        }
    }
}