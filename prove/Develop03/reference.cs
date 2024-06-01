using System;

// Defines the reference class
class Reference{
    private string book;    // Member variable book
    private int chapter;    // Member variable chapter
    private int startVerse; // Member variable startVerse
    private int endVerse;   // Member varialbe endVerse

    public Reference(string book, int chapter, int startVerse)  // Constructor for the Reference class if there is no endVerse
    {
        // defines each of the variables for the Reference class
        this.book = book;
        this.chapter = chapter;
        this.startVerse = startVerse;
        this.endVerse = startVerse;     // If there is no endVerse, the endVerse = startVerse
    }

    public Reference(string book, int chapter, int startVerse, int endVerse) // Constructor for the Reference class if there is an endVerse
    {
        // defines each of the variables for the Reference class
        this.book = book;
        this.chapter = chapter;
        this.startVerse = startVerse;
        this.endVerse = endVerse;   
    }

    public string GetBook(){    // Getter for the book variable

        return book;
    }

    public string GetChapter(){     // Getter for the chapter variable

        return chapter.ToString();  // Returns the chapter variable as a string so it can be printed
    }

    public string GetVerses(){      // Getter for the startVerse and endVerse variables
        
        if (startVerse == endVerse){    // if startVerse == endVerse, there is no endVerse, so it only returns startVerse
            return startVerse.ToString();
        } else
        {
            return startVerse.ToString() + "-" + endVerse.ToString();   // if there is an endVerse, it returns both with a dash in between
        }
    }
}
