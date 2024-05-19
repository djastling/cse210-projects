using System;
using System.IO;

// Defines the Entry Class
public class Entry
{
    // Defines the properties of the Entry Class
    public string dateText;
    public string _prompt;
    public string _entry;

    // Constructor for the Entry Class
    public Entry(string _prompt, string _entry, string dateText)
    {
        this._prompt = _prompt;
        this._entry = _entry;
        this.dateText = dateText;
    }
}