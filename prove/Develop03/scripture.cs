using System;
using System.IO;
using System.Linq;

// Defines the Scripture Class
class Scripture
{
    // Defines the member variables
    private Reference reference;    // Defines the reference variable (with datatype Reference)
    private string scripture;       // Defines the scripture variable 
    private List<Word> wordList = new List<Word>(); // Creates the wordList with datatypes as the Word class

    public Scripture(Reference reference, string scripture) // Constructor for the Scripture class
    {
        this.reference = reference; // defines the reference as the reference class
        this.scripture = scripture; // defines the scripture variable as the scripture string
        this.wordList = new List<Word>();   // defines the wordList by creating a new list
        LoadScripture(scripture);   // calls the LoadScripture method and passes in the scripture string
    }

    // defines the ScriptureLoop method
    public static void ScriptureLoop(Scripture newScripture) 
    {
        bool keepLooping = true;    // Creates the keepLooping bool which determines if the while loop continues
        while(keepLooping == true)  // Starts the while loop which continues if keepLooping == true
        {
            newScripture.DisplayScripture();    //Calls the DisplayScripture method
            newScripture.RemoveRandomWord(7);  // Calls the RemoveRandomWord method and passes in the number of words removed each round

            Console.WriteLine("Press Enter to continue or type 'quit' to finish:"); // Displays the user's control options
            string input = Console.ReadLine();              // Reads the users input
            if (input == "quit")                            // If the user enters quit, the while loop ends
            {
                keepLooping = false;
            } else if (newScripture.CheckIfDone() == true)  // If there are no words left, the loop ends
            {
                keepLooping = false;
                newScripture.DisplayScripture();            // Displays the verse one last time
            }
        }
    }

    public void LoadScripture(string scripture)             // Defines the LoadScripture method, which loads the scripture into wordList
    {
        string[] words = scripture.Split(' ');              // Splits the scripture by spaces
        int count = 0;                                      // Starts the counter for the for loop
        foreach (string word in words)                      // For loop for each word in the scripture
        {
            Word newWord = new Word(count, true, word);     // Creates a new Word, gives it an index and a Printable value of true
            wordList.Add(newWord);                          // Adds the Word to the wordList
            count++;                                        // Adds to the counter
        }
    }

    public void DisplayScripture()                  // Defines the DisplayScripture method
    {
        Console.Clear();                            // Clears the console so the scripture stays in the same place
        Console.WriteLine($"{reference.GetBook()} {reference.GetChapter()}:{reference.GetVerses()}");   // Displays the reference using getters
        foreach (Word word in wordList)             // Starts a for loop which interates through the words and prints if Printable = true
        {  
            if (word.Printable() == true){          // Checks if Printable == true
                Console.Write(word.GetWord() + " ");   // Prints the word using a getter
            } else {
                string underScores = SetWordUnderscore(word.GetWord()); // Calls the SetWordUnderscore method if Printable != true
                Console.Write(underScores + " ");                       // Prints the underscores with a space afterwards
            }
            
        }
        Console.WriteLine();    // puts a space after the verse
    }

    public void RemoveRandomWord(int wordsToDelete){        // Removes a desired amount of words from the wordList by setting Printable to false
        for (int i = 0; i < wordsToDelete; i++)             // For loop to interate through each word it will delete
        {
            Random random = new Random();                   // Calls the random Class
            int randomNumber = random.Next(0, wordList.Count);  // Picks a random number from the wordList

            foreach (Word word in wordList)                 // Iterates through the wordList to find the word to remove
            {
                if (word.GetIndex() == randomNumber)
                word.SetPrintable(false);                   // Removes the word by using setters to set Printable to false
            }
        }
    }

    private static string SetWordUnderscore(string word){   // Method to replace word in Word to underscores
        string underScores = "";    // Creates Underscore variable

        for (int i = 0; i < word.Length; i++)   // For loop to replace each letter with underscores
        {
            underScores += "_";
        }

        return underScores;         // Returns a string with the correct number of underscores
    }

    private bool CheckIfDone(){     // Defines the CheckIfDone method which checks if there are no more words in the verse

        foreach (Word word in wordList){    // Foreach loop that ends if one of the words still remains
            if (word.Printable()==true){
                return false;
            } 
        }
        return true;                        // If the foreach loop doesn't end, there are no more words and it returns true
    }

    public static Scripture ChooseRandomScripture(){    // Defines the ChooseRandomScripture method which chooses the scripture to memorize    

        string fileContent = File.ReadAllText("scriptures.txt");    // Opens the scriptures.txt file and saves it to fileContent
        string[] indexes = fileContent.Split('|');                  // Splits the fileContent into indexes by verse

        Random random = new Random();       // Calls the Random class
        int randomIndex = random.Next(0, indexes.Length);   // Chooses a random number from the number of verses

        string[] verse = indexes[randomIndex].Split('~');   // Splits the reference and scripture into indexes by the delimintator ~

        //Creates a new instance of the reference class, passing in the indexes for the Book, Chapter, startVerse, and endVerse
        Reference reference = new Reference(verse[0], int.Parse(verse[1]), int.Parse(verse[2]), int.Parse(verse[3]));

        // Creates a new instance of the scripture class, passing in reference and the scripture
        Scripture scripture = new Scripture(reference, verse[4]);

        // returns scripture with datatype Scripture
        return scripture;
    }
}