using System;
class Program
{
    static void Main(string[] args)
    {
        Console.Clear();
        Console.WriteLine("Welcome to the budgeting app!\n"); // welcomes the user to the app
        Menu menu = new Menu(); // creates a new menu object
        menu.WhileLoop();    // calls the WhileLoop method from the menu class
    }
}