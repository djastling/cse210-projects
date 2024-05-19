using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Security.Cryptography.X509Certificates;
using System.Text.Json.Serialization;
/*
Title: Develop 02; Journal
Author: Dallin Astling

Purpose: To create a journal program that allows user to write, display, save and load journal entries.

I exceeded the requirements of the assignment by writing the entries to a csv file, which can be easily opened in a program such as Excel. 
*/

// Defines the Program Class
class Program
{
    public static void Main(string[] args)
    {

        // Welcome message for the program
        Console.WriteLine("Welcome to the Journal Program!");
        
        // Creates a new instance of the Journal class
        Journal journal1 = new Journal();

        // Creates a string variable to store the user's input
        string input = "";

        // Creates a while loop that will run until the user enters "5"
        while(input != "5")
        {
            // Calls the MenuInput method and stores the user's input 
            input = MenuInput();

            // If the user enters "1", the WriteNewEntry method is called
            if (input == "1")
            {
                journal1.WriteNewEntry();
            }
            
            // If the user enters "2", the DisplayEntries method is called
            else if (input == "2")
            {
                journal1.DisplayEntries();
            }

            // If the user enters "3", the SaveJournal method is called
            else if (input == "3")
            {
                journal1.SaveJournal();
            }

            // If the user enters "4", the LoadJournal method is called
            else if (input == "4")
            {
                journal1.LoadJournal();
            }

            // If the user enters "5", the program will print "Goodbye!" and exit the program
            else if (input == "5")
            {
                Console.WriteLine("Goodbye!");
            }

            // If the user enters a false input, the program will print an error message
            else
            {
                Console.WriteLine("Invalid input. Please try again.");
            }
        }
            
    }
    
    // Defines the MenuInput method
    public static string MenuInput()
    {
        // Prints the menu options
        Console.WriteLine("Please select an option:");

        // Creates a list of strings to store the menu options
        List<string> welcomeMenu = new List<string> 
        {"1. Write a new entry", 
        "2. Display the journal", 
        "3. Save the journal to a file", 
        "4. Load the journal from a file", 
        "5. Exit"};

        // Interates through the list of options and prints them
        for (int i = 0; i < welcomeMenu.Count; i++)
        {
            Console.WriteLine(welcomeMenu[i]);
        }

        // Stores the user's input
        string entry = Console.ReadLine();

        // Returns the user's input
        return entry;
    }
}