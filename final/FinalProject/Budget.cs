using System;
class Budget{
    // List to hold the budget categories
    static List<BudgetCategory> budgetList = new List<BudgetCategory>();

    // List of categories
    static List<string> categories = new List<string> {
        "Rent",
        "Gas",
        "Groceries",
        "Shopping",
        "Eating Out",
        "Utilities",
        "Medical",
        "Education",
        "Subscriptions"
    };

    // Method to start a new budget
    public static void StartBudget()
    {
        // Asks the user for the month they would like to budget for
        Console.Write("What month would you like to budget for? ");
        string budgetMonth = Console.ReadLine();

        // Asks the user for the budget for each category
        Console.WriteLine("Please enter your budget for the following categories:");

        // Loops through the categories and lets the user set a budget for each category
        foreach (string category in categories){
            Console.Write($"{category}: ");
            BudgetCategory newCategory = new BudgetCategory(category, budgetMonth, int.Parse(Console.ReadLine()));
            budgetList.Add(newCategory);
        }

        // Displays the budget list that the user has set
        foreach (BudgetCategory line in budgetList){

            Console.WriteLine($"{line.GetCategory()} {line.GetMonth()} {line.GetAmount()}");
        }
    }

    // Method to view the budget
    public static void ViewBudget(){

        // Checks if the user has set a budget
        if (budgetList.Count == 0){
            Console.WriteLine("You have not set a budget yet. Please set a budget first.");
            return;
        }

        // Adds up the budget for each category
        AddUpBudget budgetTotals = new AddUpBudget();

        // Gets the transaction list
        List<Transaction> transactionList = InputTransaction.transactionList;

        // Adds up the budget for each category
        budgetTotals.AddingUpBudget(InputTransaction.transactionList);
        string month = "";

        // Gets the month in word form (ie January, Febuary, etc insteamd of 01, 02, etc)
        string transactionMonth = transactionList[0].GetDate().Split('/')[0];
        month = FindMonth(transactionMonth);

        // Creates a list of the budget totals from the transactionlist
        List<BudgetCategory> finalBudgets = new List<BudgetCategory>();
        finalBudgets.Add(new BudgetCategory("Gas", month, budgetTotals.GetGasTotal()));
        finalBudgets.Add(new BudgetCategory("Eating Out", month, budgetTotals.GetEatingOutTotal()));
        finalBudgets.Add(new BudgetCategory("Groceries", month, budgetTotals.GetGroceriesTotal()));
        finalBudgets.Add(new BudgetCategory("Shopping", month, budgetTotals.GetShoppingTotal()));
        finalBudgets.Add(new BudgetCategory("Subscriptions", month, budgetTotals.GetSubscriptionTotal()));
        finalBudgets.Add(new BudgetCategory("Utilities", month, budgetTotals.GetUtilitiesTotal()));
        finalBudgets.Add(new BudgetCategory("Medical", month, budgetTotals.GetMedicalTotal()));
        finalBudgets.Add(new BudgetCategory("Education", month, budgetTotals.GetEducationTotal()));
        finalBudgets.Add(new BudgetCategory("Rent", month, budgetTotals.GetRentTotal()));
        double difference = 0;

        // displays each of the categories
        Console.WriteLine("{0,-15} {1,-10} {2,-20} {3,-15}","Category", "Budget", "Amount Spent", "Difference");
        Console.WriteLine(new string('-', 70));

        // Displays the set budget and final budget for each category
        for (int i = 0; i < finalBudgets.Count; i++){
            Console.WriteLine("{0,-15} {1,-10} {2,-20} {3,-15}", finalBudgets[i].GetCategory(), budgetList[i].GetAmount().ToString("F2"), (finalBudgets[i].GetAmount() * -1).ToString("F2"), (finalBudgets[i].GetAmount() + budgetList[i].GetAmount()).ToString("F2"));
            difference += finalBudgets[i].GetAmount() + budgetList[i].GetAmount();
        }

        // Displays the total difference
        if (difference < 0){
            Console.WriteLine($"You overspent by ${(-1 * difference).ToString("F2")}");
        } else {
            Console.WriteLine($"You stayed ${difference} under your budget!");
        }

        // Prompts the user to press enter to continue
        Console.Write("Press Enter to continue...");
        Console.ReadLine();

    }

    // Method to find the month in word form
    private static string FindMonth(string transactionMonth){
        string month = "";
        if (transactionMonth == "01" || transactionMonth == "1"){
            month = "January";
        } else if (transactionMonth == "02" || transactionMonth == "2"){
            month = "February";
        } else if (transactionMonth == "03" || transactionMonth == "3"){
            month = "March";
        } else if (transactionMonth == "04" || transactionMonth == "4"){
            month = "April";
        } else if (transactionMonth == "05" || transactionMonth == "5"){
            month = "May";
        } else if (transactionMonth == "06" || transactionMonth == "6"){
            month = "June";
        } else if (transactionMonth == "07" || transactionMonth == "7"){
            month = "July";
        } else if (transactionMonth == "08" || transactionMonth == "8"){
            month = "August";
        } else if (transactionMonth == "09" || transactionMonth == "9"){
            month = "September";
        } else if (transactionMonth == "10"){
            month = "October";
        } else if (transactionMonth == "11"){
            month = "November";
        } else if (transactionMonth == "12"){
            month = "December";
        }
        return month;
    }

    // Getter for the budget list
    public static List<BudgetCategory> GetBudgetList(){
        return budgetList;
    }

    // Setter for the budget list
    public static void SetBudgetList(List<BudgetCategory> newBudgetList){
        budgetList = newBudgetList;
    }
}