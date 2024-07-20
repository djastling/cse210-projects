using System;
using System.IO;

class Menu{
    private static void DisplayMenu()
    {
        Console.WriteLine("Welcome to the budgeting app!\n");
        Console.WriteLine("Choose an option from the Menu:");
        Console.WriteLine("1. Input monthy transactions");
        Console.WriteLine("2. View transactions");
        Console.WriteLine("3. Set a budget");
        Console.WriteLine("4. View budget");
        Console.WriteLine("5. Save information to a file");
        Console.WriteLine("6. Load information from a file");
        Console.WriteLine("7. Categorize transactions");
        Console.WriteLine("8. Exit");
    }

    public void WhileLoop(){
        string choice = "0";
        bool setBudget = false;
        bool inputTransactions = false;
        while (choice != "8")
        {
            DisplayMenu();
            Console.Write("\nEnter your choice: ");
            choice = Console.ReadLine();
            switch (choice)
            {
                case "1":
                    InputTransaction.InputNewTransactions();
                    break;
                case "2":
                    InputTransaction.DisplayTransactions();
                    break;
                case "3":
                    Budget.StartBudget();
                    setBudget = true;
                    break;
                case "4":
                    Budget.ViewBudget();
                    break;
                case "5":
                    SaveInformation.SaveToFile();
                    break;
                case "6":
                    LoadInformation.LoadInInformation();
                    break;
                case "7":
                    CategorizeTransactions.categorize();
                    break;
                case "8":
                    Console.WriteLine("You chose to exit.");
                    break;
                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;
            }
        }
    }
}