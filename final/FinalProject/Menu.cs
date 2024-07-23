using System;
using System.IO;
class Menu{
    private static void DisplayMenu()
    {
        // Display the menu options
        Console.WriteLine("Choose an option from the Menu:");
        Console.WriteLine("1. Input monthy transactions");
        Console.WriteLine("2. View transactions");
        Console.WriteLine("3. Set a budget");
        Console.WriteLine("4. View budget");
        Console.WriteLine("5. Save information to a file");
        Console.WriteLine("6. Load information from a file");
        Console.WriteLine("7. Exit");
    }

    public void WhileLoop()
    {
        // initiates choice variable
        string choice = "0";

        // loop to display the menu until the user chooses to exit
        while (choice != "7")
        {
            // prints the menu and prompts user for their input
            DisplayMenu();
            Console.Write("\nEnter your choice: ");
            choice = Console.ReadLine();

            // switch statement to determine which method to call based on user input
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
                    Console.WriteLine("You chose to exit.");
                    break;
                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;
            }
        }
    }
}