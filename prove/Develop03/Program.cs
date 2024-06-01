using System;

class Program //starts the program class
{
    
    static void Main(string[] args)
    {
        Scripture scripture = Scripture.ChooseRandomScripture(); //Calls the ChooseRandomScripture method and returns a scripture
        Scripture.ScriptureLoop(scripture); // Calls the ScriptureLoop method and gives it the scripture variable
    }
}