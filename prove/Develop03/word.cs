using System;

// defines the word class
class Word{
    private int index;      // Member variable for index
    private string word;    // Member variable for word
    private bool printWord; // Member variable for printWord

    public Word(int index, bool printWord, string word) // Constructor for the Word class
    {
        // defines the variables in the Word Constructor
        this.index = index;
        this.word = word;
        this.printWord = printWord;
    }

    public string GetWord() // Defines the getter for word
    {
        return word;
    }

    public bool Printable() // defines the getter for printWord
    {
        return printWord;
    }

    public int GetIndex()   // defines the Getter for index
    {
        return index;
    }

    public void SetPrintable(bool set)  // defines the setter to allow other classes to set printWord
    {
        printWord = set;
    }
}