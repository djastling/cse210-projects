using System;
class Budget{
    static List<BudgetCategory> budgetList = new List<BudgetCategory>();
    public static void StartBudget(){

        Console.Write("What month would you like to budget for? ");
        string budgetMonth = Console.ReadLine();

        Console.WriteLine("Please enter your budget for the following categories:");

        List<string> categories = new List<string> {
            "Rent",
            "Gas",
            "Groceries",
            "Shopping",
            "Eating Out",
            "Utilities",
            "Medical",
            "Education"
        };
        foreach (string category in categories){
            Console.Write($"{category}: ");
            BudgetCategory newCategory = new BudgetCategory(category, budgetMonth, int.Parse(Console.ReadLine()));
            budgetList.Add(newCategory);
        }

        foreach (BudgetCategory line in budgetList){
            Console.WriteLine($"{line.GetCategory()} {line.GetMonth()} {line.GetAmount()}");
        }
    }
    public static void ViewBudget(){

        Console.WriteLine("{0,-15} {1,-10} {2,-20} {3,-15}","Category", "Budget", "Amount Spent", "Difference");

        Console.WriteLine(new string('-', 70));

        AddUpBudget budgetTotals = new AddUpBudget(0, 0, 0, 0, 0);
        budgetTotals.AddingUpBudget(InputTransaction.transactionList);

        List<BudgetCategory> finalBudgets = new List<BudgetCategory>();
        finalBudgets.Add(new BudgetCategory("Gas", "July", budgetTotals.GetGasTotal()));
        finalBudgets.Add(new BudgetCategory("Eating Out", "July", budgetTotals.GetEatingOutTotal()));
        finalBudgets.Add(new BudgetCategory("Groceries", "July", budgetTotals.GetGroceriesTotal()));
        finalBudgets.Add(new BudgetCategory("Shopping", "July", budgetTotals.GetShoppingTotal()));
        finalBudgets.Add(new BudgetCategory("Subscriptions", "July", budgetTotals.GetSubscriptionTotal()));
        double difference = 0;
        for (int i = 0; i < finalBudgets.Count; i++){
            Console.WriteLine("{0,-15} {1,-10} {2,-20} {3,-15}", finalBudgets[i].GetCategory(), budgetList[i].GetAmount().ToString("F2"), (finalBudgets[i].GetAmount() * -1).ToString("F2"), (finalBudgets[i].GetAmount() + budgetList[i].GetAmount()).ToString("F2"));
            difference += finalBudgets[i].GetAmount() + budgetList[i].GetAmount();
        }
        if (difference < 0){
            Console.WriteLine($"You overspent by ${-1 * difference}");
        } else {
            Console.WriteLine($"You stayed ${difference} under your budget!");
        }
        Console.Write("Press Enter to continue...");
        Console.ReadLine();

    }

    public static List<BudgetCategory> GetBudgetList(){
        return budgetList;
    }
    public static void SetBudgetList(List<BudgetCategory> newBudgetList){
        budgetList = newBudgetList;
    }
}