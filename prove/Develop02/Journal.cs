using System;
using System.Security.Cryptography;
using System.IO;
using System.Security.Cryptography.X509Certificates;
using System.Transactions;

// Defines the Journal class
public class Journal
{
    // Creates a list of Entries to be stored
    public List<Entry> _entryList = new List<Entry>();

    // Creates a list of prompts
    public List<string> _promptList = new List<string>
    {
        "Who was the most interesting person that I interacted with today?",
        "What was the best part of my day?",
        "What was something new you learned today?",
        "What are you grateful for today?",
        "What was the most challenging part of your day?"
    };

    // Method that displays the menu options and returns the user's input
    public void WriteNewEntry()
    {
        string _prompt = DisplayPrompt();
        string _entry = Console.ReadLine();
        DateTime theCurrentTime = DateTime.Now;
        string dateText = theCurrentTime.ToShortDateString();
        
        Entry entry = new Entry(_prompt, _entry, dateText);
        _entryList.Add(entry);
    }

    // Method that displays a random prompt from the list
    public string DisplayPrompt()
    {
        Random randomGenerator = new Random();
        int number = randomGenerator.Next(0, _promptList.Count);
        Console.WriteLine(_promptList[number]);

        return _promptList[number];
    }

    // Method that displays all the current entries in the journal
    public void DisplayEntries()
    {
        foreach (var line in _entryList)
        {
            Console.WriteLine($"{line.dateText} - Prompt: {line._prompt}");
            Console.WriteLine($"{line._entry}");
        }
    }

    // Method that saves the journal to a file
    public void SaveJournal()
    {
        Console.WriteLine("What is the filename?");
        string fileName = Console.ReadLine();
        using (StreamWriter outputFile = new StreamWriter(fileName))
        {
            foreach (Entry line in _entryList)
            {
                outputFile.WriteLine($"{line.dateText}~~{line._prompt}~~{line._entry}");
            }
        }
        Console.WriteLine("Journal saved to file.");
    }

    // Method that loads the journal from a file
    public void LoadJournal()
    {
        Console.WriteLine("What is the filename?");
        string fileName = Console.ReadLine();

        string[] fileLines = System.IO.File.ReadAllLines(fileName);

        foreach (string line in fileLines)
        {
            string[] parts = line.Split("~~");
            Console.WriteLine($"{parts[0]}: - Prompt: {parts[1]}");
            Console.WriteLine($"{parts[2]}");
        }
    }
}
